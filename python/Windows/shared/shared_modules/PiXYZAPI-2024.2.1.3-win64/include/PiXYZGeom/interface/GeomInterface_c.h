// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_GEOM_INTERFACE_GEOMINTERFACE_C_H_
#define _PXZ_GEOM_INTERFACE_GEOMINTERFACE_C_H_

#include "GeomTypes_c.h"

PXZ_EXPORTED char * Geom_getLastError();

// Apply a transformation matrix to a geometrical entity
PXZ_EXPORTED void Geom_applyTransform(Session * pxzSession, Geom_GeomEntity entity, Geom_Matrix4 matrix);
PXZ_EXPORTED void Geom_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Retrieve the Axis-Aligned Bounded Box of a geometric entity
PXZ_EXPORTED Geom_AABB Geom_getEntityAABB(Session * pxzSession, Geom_GeomEntity entity);

// ----------------------------------------------------
// Math
// ----------------------------------------------------

// Construct a Change of Basis Matrix (e.g multiplying the point [0,0,0] will result to the point origin)
PXZ_EXPORTED Geom_Matrix4 Geom_changeOfBasisMatrix(Session * pxzSession, Geom_Point3 origin, Geom_Vector3 x, Geom_Vector3 y, Geom_Vector3 z);
// Create a Matrix from an Affine
PXZ_EXPORTED Geom_Matrix4 Geom_fromAffine(Session * pxzSession, Geom_Affine affine);
// Get camera position, up and target vectors
typedef struct {
   Geom_Point3 position;
   Geom_Vector3 up;
   Geom_Point3 target;
} Geom_fromLookAtMatrixReturn;
PXZ_EXPORTED Geom_fromLookAtMatrixReturn Geom_fromLookAtMatrix(Session * pxzSession, Geom_Matrix4 matrix, Geom_Distance distanceFromTarget);
// Create a Matrix from an origin and a normal vector
PXZ_EXPORTED Geom_Matrix4 Geom_fromOriginNormal(Session * pxzSession, Geom_Point3 origin, Geom_Vector3 normal);
// Create a Matrix from translation, rotation and scaling vectors
PXZ_EXPORTED Geom_Matrix4 Geom_fromTRS(Session * pxzSession, Geom_Vector3 T, Geom_Vector3 R, Geom_Vector3 S);
// Get maximum matrix scale
PXZ_EXPORTED Core_Double Geom_getMaxScale(Session * pxzSession, Geom_Matrix4 matrix);
// Invert a matrix
PXZ_EXPORTED Geom_Matrix4 Geom_invertMatrix(Session * pxzSession, Geom_Matrix4 matrix);
// Create a matrix from a camera position, up and target
PXZ_EXPORTED Geom_Matrix4 Geom_lookAtMatrix(Session * pxzSession, Geom_Point3 position, Geom_Vector3 up, Geom_Point3 target);
// Multiply two matrices, returns left*right
PXZ_EXPORTED Geom_Matrix4 Geom_multiplyMatrices(Session * pxzSession, Geom_Matrix4 left, Geom_Matrix4 right);
// Multiply a point by a matrix (i.e apply the matrix to a point)
PXZ_EXPORTED Geom_Point3 Geom_multiplyMatrixPoint(Session * pxzSession, Geom_Matrix4 matrix, Geom_Point3 point);
// Multiply a vector by a matrix (i.e apply the matrix to a vector)
PXZ_EXPORTED Geom_Vector3 Geom_multiplyMatrixVector(Session * pxzSession, Geom_Matrix4 matrix, Geom_Vector3 vector);
// Create an orthographic matrix from a 3D width, a 3D height, a near, and a far clipping distance
PXZ_EXPORTED Geom_Matrix4 Geom_orthographicMatrix(Session * pxzSession, Core_Double width3D, Core_Double height3D, Geom_Distance nearClipDistance, Geom_Distance farClipDistance);
// Create a perspective matrix from a fovX, an aspect ratio, a near, and a far clipping distance
PXZ_EXPORTED Geom_Matrix4 Geom_perspectiveMatrix(Session * pxzSession, Geom_Angle fovX, Core_Double aspectRatio, Geom_Distance nearClipDistance, Geom_Distance farClipDistance);
// Decompose a Matrix into translation, rotation and scaling vectors
PXZ_EXPORTED Geom_Vector3List Geom_toTRS(Session * pxzSession, Geom_Matrix4 matrix);

// ----------------------------------------------------
// debug
// ----------------------------------------------------




#endif
