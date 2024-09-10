#ifndef _PXZCORE_INTERFACE_INTERFACEBASE_H_
#define _PXZCORE_INTERFACE_INTERFACEBASE_H_

# define PXZ_STRINGIFY_HELPER(a) #a
# define PXZ_STRINGIFY(a) PXZ_STRINGIFY_HELPER(a)

/****************************************
* Module management & namespaces stuff *
****************************************/
#define PXZ_NS PiXYZ

#ifdef PXZ_DISABLE_NAMESPACE
# define PXZ_NS_BEGIN
# define PXZ_NS_END
# define USE_PXZ
# define PXZ_USE_MODULE(moduleName) using namespace moduleName;
#else
# define PXZ_NS_BEGIN namespace PXZ_NS {
# define PXZ_NS_END }
# define USE_PXZ using namespace PXZ_NS;
# define PXZ_USE_MODULE(moduleName) using namespace PXZ_NS::moduleName;
# define PXZ_USE_GUI_MODULE(moduleName) using namespace PXZ_NS::moduleName::GUI;
#endif

#define PXZ_MODULE_BEGIN(moduleName) \
   PXZ_NS_BEGIN \
namespace moduleName {

#define PXZ_MODULE_END \
} \
   PXZ_NS_END

/*******************************
* Interface linkage macro     *
*******************************/
#ifndef PXZ_EXPORTED
#if defined(_MSC_VER)
# if defined(PXZ_BUILDING_SHARED)
#   define PXZ_EXPORTED  __declspec(dllexport)
#  else
#   define PXZ_EXPORTED __declspec(dllimport)
# endif
#else
# if __GNUC__ >= 4
#  define PXZ_EXPORTED __attribute__ ((visibility ("default")))
# else
#  define PXZ_EXPORTED
# endif
#endif
#endif

#include <cstdlib>

extern "C" {
#if defined(BUILDING_CORE_INTERFACE)
# ifdef OS_WIN32
    __declspec(dllexport) void * pxzAllocDll(size_t size);
    __declspec(dllexport) void pxzFreeDll(void * buf);
# else
    __attribute__ ((visibility ("default"))) void * pxzAllocDll(size_t size);
    __attribute__ ((visibility ("default"))) void pxzFreeDll(void * buf);
# endif
#else
   void * pxzAllocDll(size_t size);
   void pxzFreeDll(void * buf);
#endif
}

inline void * pxzAlloc(size_t size)
{
#ifdef BUILDING_PXZ
   return malloc(size);
#else
   return pxzAllocDll(size);
#endif
}

inline void pxzFree(void * buf)
{
#ifdef BUILDING_PXZ
   free(buf);
#else
   pxzFreeDll(buf);
#endif
}

#include "List.h"
#include "Array.h"
#include "String.h"
PXZ_MODULE_BEGIN(CoreI)

typedef int32_t None;
typedef int32_t Int;
typedef uint32_t UInt;
typedef uint32_t Ident;
typedef int16_t Short;
typedef uint16_t UShort;
typedef double Double;
typedef int64_t Long;
typedef bool Bool;
typedef uint8_t Byte;
typedef uint64_t ULong;
typedef void* Ptr;

class Exception
{
private:
   String _desc;
public:
   Exception(const String & desc) : _desc(desc) {}
   const String & getDescription() const { return _desc; }
};

class InterruptException : public Exception {
public:
   InterruptException(const String & desc) : Exception(desc) {}
};


PXZ_MODULE_END

#endif
