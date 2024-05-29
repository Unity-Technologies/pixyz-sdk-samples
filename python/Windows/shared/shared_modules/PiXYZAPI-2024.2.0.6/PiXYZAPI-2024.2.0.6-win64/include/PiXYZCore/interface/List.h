#ifndef _PXZ_CORE_INTERFACE_LIST_H_
#define _PXZ_CORE_INTERFACE_LIST_H_

#include <cstring>
#include <type_traits>
#include <initializer_list>
#include "InterfaceBase.h"

PXZ_MODULE_BEGIN(CoreI)

template<typename T>
class List
{
private:
   T * _tab;
   size_t _size;

public:
   List()
      : _tab(0)
      , _size(0)
   {}

   explicit List(size_t size)
      : _tab(0)
      , _size(size)
   {
      alloc();
   }

   List(const List & o)
      : _tab(0)
   {
	  dealloc();
      _size = o.size();
      alloc();
      for (size_t i = 0; i < size(); ++i) _tab[i] = o._tab[i];
   }

   List(size_t count, const T & v)
      : _tab(0)
   {
	  dealloc();
      _size = count;
      alloc();
      for (size_t i = 0; i < size(); ++i) _tab[i] = v;
   }

   List(size_t s, const T * t)
      : _tab(0)
   {
      set(s, t);
   }

   List(std::initializer_list<T> l)
      : _tab(0)
   {
      dealloc();
      _size = l.size();
      alloc();
      for (size_t i = 0; i < size(); ++i) _tab[i] = *(l.begin() + i);
   }

   const List & operator=(const List & o)
   {
	  dealloc();
      _size = o.size();
      alloc();
      for (size_t i = 0; i < size(); ++i) _tab[i] = o._tab[i];
      return *this;
   }

   virtual ~List() { dealloc(); }

   const T & operator[](size_t index) const { return _tab[index]; }
   T & operator[](size_t index) { return _tab[index]; }

   List & set(int index, const T & value) { _tab[index] = value; return *this; }
   List & set(size_t s, const T * t) 
   { 
	  dealloc();
      _size = s;
      alloc();
      if (std::is_fundamental<T>::value) {
         memcpy(_tab, t, sizeof(*t)*s);
      } else {
         for (size_t i = 0; i < size(); ++i)
            _tab[i] = t[i];
      }
      return *this;
   }

   const T & front() const { return _tab[0]; }
   T & front() { return _tab[0]; }

   const T & back() const { return _tab[size() - 1]; }
   T & back() { return _tab[size()-1]; }

   const T * c_tab() const { return _tab; }   
   size_t size() const { return _size; }

private:
   void alloc()
   {
      if (_tab) dealloc();
      if (size() > 0)
         _tab = reinterpret_cast<T*>(pxzAlloc(size()*sizeof(T)));
      if (!std::is_fundamental<T>::value) {
         for (size_t i = 0; i < size(); ++i) {
            new (&_tab[i]) T();
         }
      }
   }

   void dealloc()
   {
      if (_tab) {
         if (!std::is_fundamental<T>::value) {
            for (size_t i = 0; i < size(); ++i) {
               _tab[i].~T();
            }
         }
         pxzFree(_tab);
         _tab = 0;
      }
   }
};

PXZ_MODULE_END

#endif
