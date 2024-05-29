#ifndef _PXZ_PiXYZAPI_C_H_
#define _PXZ_PiXYZAPI_C_H_

#include <PiXYZCore/interface/CoreTypes_c.h>

PXZ_EXPORTED char* API_getLastError();

PXZ_EXPORTED Session * PiXYZ_API_Initialize(Core_String productName, Core_String validationKey, Core_String license = "");
PXZ_EXPORTED void PiXYZ_API_Release(Session * session);

typedef struct {
   size_t size;
   Session ** list;
} SessionList;
PXZ_EXPORTED void SessionList_init(SessionList * list, size_t size);
PXZ_EXPORTED void SessionList_free(SessionList * list);

PXZ_EXPORTED SessionList PiXYZ_API_ActiveSessions();

#endif
