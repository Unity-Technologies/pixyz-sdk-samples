#pragma warning disable CA2101

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace UnityEngine.Pixyz.API
{
	public class Interface
	{
		[DllImport(PiXYZAPI.memcpy_dll, EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false), SuppressUnmanagedCodeSecurity]
		private static unsafe extern void* memcpy(void* dest, void* src, ulong count);

		private protected static unsafe T[] CopyMemory<T>(IntPtr pointer, int length)
		{
			T[] managedArray = new T[length];
			GCHandle handle = GCHandle.Alloc(managedArray, GCHandleType.Pinned);
			IntPtr ptr = handle.AddrOfPinnedObject();
			void* nativePtr = pointer.ToPointer();
			memcpy(ptr.ToPointer(), nativePtr, (ulong)(length * Marshal.SizeOf(typeof(T))));
			handle.Free();
			return managedArray;
		}

		private protected static unsafe String ConvertValue(IntPtr s)
		{
			return new string((sbyte*)s);
		}

        private protected static bool ConvertValue(byte b)
        {
            return Convert.ToBoolean(b);
        }

        private protected static byte ConvertValue(bool b)
        {
            return Convert.ToByte(b);
        }

        private protected static IntPtr ConvertValue(string s)
		{
			return Marshal.StringToHGlobalAnsi(s);
		}

		private protected static bool ConvertValue(int b)
		{
			return (b != 0);
		}

		public class PixyzCallbackTask
		{
			public abstract class BaseTaskExecution<T> : IDisposable where T : struct
			{
				protected ConcurrentQueue<T> _params;
				protected volatile SemaphoreSlim _isCompleted = null;
				protected volatile SemaphoreSlim _isUpdated = null;
				protected volatile uint _callbackId;
				protected volatile bool _isDisposed = false;
				protected volatile bool _isContiniuous = false;
				protected GCHandle _delegatePtr;

				private volatile CancellationTokenSource _cancelTokenSource = null;
				private CancellationToken _cancelToken;

				public BaseTaskExecution(CancellationTokenSource cancelTokenSource = null)
				{
					_isCompleted = new SemaphoreSlim(0, 1);
					_isUpdated = new SemaphoreSlim(0);
					_params = new ConcurrentQueue<T>();
					if (_cancelTokenSource != null)
					{
						_cancelToken = cancelTokenSource.Token;
						_cancelTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancelTokenSource.Token);
					}
					else
					{
						_cancelTokenSource = new CancellationTokenSource();
						_cancelToken = _cancelTokenSource.Token;
					}
				}

				protected abstract void AttachCallback();

				protected abstract void DetachCallback();

				protected void Run(bool continiuous)
				{
					if (_isDisposed)
						throw new Exception("This TaskExecution was disposed, you can't run it.");

					_isContiniuous = continiuous;
					try
					{						
						_isCompleted.Wait(_cancelToken);

						Dispose();
					}
					catch (OperationCanceledException)
					{
						Dispose();
					}
				}

				public Task RunContiniuous()
				{
					AttachCallback();
					return Task.Run(() => { Run(true); });
				}

				public Task<T> RunOnce()
				{
					if (_isDisposed)
						throw new Exception("This TaskExecution was disposed, you can't run it.");

					try
					{
						AttachCallback();
						return Task.Run(() =>
						{
							Run(false);
							T result = new T();
							_params.TryDequeue(out result);
							return result;
						});
					}
					catch (OperationCanceledException)
					{
						Dispose();
						return Task.FromResult(new T());
					}
				}

				public void Stop()
				{
					if (!_cancelTokenSource.IsCancellationRequested)
						_cancelTokenSource.Cancel();
				}

				public async Task<T> WaitNewValue()
				{
					T result = new T();
					do
					{
						bool success = _params.TryDequeue(out result);
						if (success)
							return result;
						else
							await _isUpdated.WaitAsync(_cancelToken);
					} while (!_params.IsEmpty && !_cancelToken.IsCancellationRequested);
					return result;
				}

				public void Dispose()
				{
					if (_isDisposed)
						return;

					_isDisposed = true;
					Stop();
					DetachCallback();

					if (_delegatePtr.IsAllocated)
						_delegatePtr.Free();

					_isCompleted.Dispose();
					_isUpdated.Dispose();
					_cancelTokenSource.Dispose();
					_isCompleted = null;
					_isUpdated = null;
				}
			}
		}
	}
}