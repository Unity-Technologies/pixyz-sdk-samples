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
	}
}