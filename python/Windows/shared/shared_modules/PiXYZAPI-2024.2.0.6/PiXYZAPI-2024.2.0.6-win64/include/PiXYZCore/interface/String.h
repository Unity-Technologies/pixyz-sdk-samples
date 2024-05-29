#ifndef _PXZ_CORE_INTERFACE_STRING_H_
#define _PXZ_CORE_INTERFACE_STRING_H_

#include <string>
#include <cstring>
#include "InterfaceBase.h"

PXZ_MODULE_BEGIN(CoreI)

class String
{
private:
   char * _tab;
   size_t _size;

public:
   String(const String & other)
      : _tab(0)
      , _size(other._size)
   {
      alloc();
      memcpy(_tab, other._tab, _size);
   }

   String() 
      : _tab(0)
      , _size(1) 
   {
      alloc();
      _tab[0] = 0;
   }

   ~String() { dealloc(); }

   String(const std::string & s)
      : _tab(0)
      , _size(s.size() + 1)
   {
      alloc();
      memcpy(_tab, s.c_str(), sizeof(char)*s.size());
      _tab[size() - 1] = 0;
   }

   String(const char * s)
      : _tab(0)
      , _size(strlen(s) + 1)
   {
      alloc();
      memcpy(_tab, s, sizeof(char)*size());
   }

   String & operator=(const char * s)
   {
      _size = strlen(s) + 1;
      alloc();
      memcpy(_tab, s, sizeof(char)*size());
      return *this;
   }

   String & operator=(const String & o)
   {
      _size = o.size();
      alloc();
      memcpy(_tab, o._tab, sizeof(char)*size());
      return *this;
   }
      
   size_t length() const { return _size - 1; }
   bool empty() const { return length() == 0; }

   const char * c_str() const { return _tab; }
   operator std::string() const { return std::string(c_str()); }

   char * c_copy() const 
   { 
      char * tab = reinterpret_cast<char*>(pxzAlloc(size())); 
      memcpy(tab, _tab, size()); 
      return tab; 
   }

private:
   size_t size() const { return _size; }
   void alloc()
   {
      if (_tab) dealloc();
      _tab = reinterpret_cast<char*>(pxzAlloc(size()));
   }

   void dealloc()
   {
      if (_tab) {
         pxzFree(_tab);
         _tab = 0;
      }
   }
};

PXZ_MODULE_END

#endif
