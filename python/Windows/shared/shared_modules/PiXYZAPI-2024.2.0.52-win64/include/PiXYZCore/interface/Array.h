#ifndef _PXZ_CORE_INTERFACE_ARRAY_H_
#define _PXZ_CORE_INTERFACE_ARRAY_H_

#include "InterfaceBase.h"

PXZ_MODULE_BEGIN(CoreI)

template<typename T, int SIZE>
class Array
{
protected:
   T _tab[SIZE] = {T()};

public:
   Array() {}

   Array(const Array & o)
   {
      for (size_t i = 0; i < size(); ++i) _tab[i] = o._tab[i];
   }

   Array(const T* tab)
   {
      for (size_t i = 0; i < size(); ++i) _tab[i] = tab[i];
   }

   Array(std::initializer_list<T> tab)
   {
      for (size_t i = 0; i < size(); ++i) _tab[i] = tab[i];
   }

   const Array & operator=(const Array & o)
   {
      for (size_t i = 0; i < size(); ++i) _tab[i] = o._tab[i];
      return *this;
   }

   const T & operator[](size_t index) const { return _tab[index]; }
   T & operator[](size_t index) { return _tab[index]; }

   Array & set(int index, const T & value) { _tab[index] = value; return *this; }

   const T * c_tab() const { return _tab; }
   size_t size() const { return (size_t)SIZE; }
};

PXZ_MODULE_END

#endif
