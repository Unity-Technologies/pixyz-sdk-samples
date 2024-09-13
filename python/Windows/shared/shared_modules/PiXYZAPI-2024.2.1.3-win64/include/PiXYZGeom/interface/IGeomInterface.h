// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_GEOM_INTERFACE_IGEOMINTERFACE_H_
#define _PXZ_GEOM_INTERFACE_IGEOMINTERFACE_H_

#include "GeomTypes.h"

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(GeomI)

class PXZ_EXPORTED IGeomInterface
{
public:
   virtual ~IGeomInterface() {}

   //! Apply a transformation matrix to a geometrical entity
   /*!
     \param entity The geometric entity
     \param matrix The transformation matrix
   */
   virtual void applyTransform(const GeomEntity & entity, const Matrix4 & matrix) = 0;

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) = 0;

   //! Retrieve the Axis-Aligned Bounded Box of a geometric entity
   /*!
     \param entity The geometric entity
     \return aabb The axis aligned bounded box
   */
   virtual AABB getEntityAABB(const GeomEntity & entity) = 0;


   /**
    * \defgroup Math 
    * @{
    */
   //! Construct a Change of Basis Matrix (e.g multiplying the point [0,0,0] will result to the point origin)
   /*!
     \param origin Origin of the new basis
     \param x X axis of the new basis
     \param y Y axis of the new basis
     \param z Z axis of the new basis
     \return changeOfBasis The change of basis matrix
   */
   virtual Matrix4 changeOfBasisMatrix(const Point3 & origin, const Vector3 & x, const Vector3 & y, const Vector3 & z) = 0;

   //! Create a Matrix from an Affine
   /*!
     \param affine The affine
     \return matrix The created Matrix
   */
   virtual Matrix4 fromAffine(const Affine & affine) = 0;

   //! Get camera position, up and target vectors
   /*!
     \param matrix The created Matrix
     \param distanceFromTarget 
     \return position The camera position
     \return up The up vector
     \return target The target position
   */
   virtual fromLookAtMatrixReturn fromLookAtMatrix(const Matrix4 & matrix, const Distance & distanceFromTarget = 1) = 0;

   //! Create a Matrix from an origin and a normal vector
   /*!
     \param origin The origin point
     \param normal The normal vector
     \return matrix The created Matrix
   */
   virtual Matrix4 fromOriginNormal(const Point3 & origin, const Vector3 & normal) = 0;

   //! Create a Matrix from translation, rotation and scaling vectors
   /*!
     \param T The translation vector
     \param R The rotations vector
     \param S The scaling vector
     \return matrix The created Matrix
   */
   virtual Matrix4 fromTRS(const Vector3 & T, const Vector3 & R, const Vector3 & S) = 0;

   //! Get maximum matrix scale
   /*!
     \param matrix 
     \return scale Max scale value
   */
   virtual CoreI::Double getMaxScale(const Matrix4 & matrix) = 0;

   //! Invert a matrix
   /*!
     \param matrix The matrix to invert
     \return inverted The inverted matrix
   */
   virtual Matrix4 invertMatrix(const Matrix4 & matrix) = 0;

   //! Create a matrix from a camera position, up and target
   /*!
     \param position The camera position
     \param up The up vector
     \param target The target position
     \return matrix The created matrix
   */
   virtual Matrix4 lookAtMatrix(const Point3 & position, const Vector3 & up, const Point3 & target) = 0;

   //! Multiply two matrices, returns left*right
   /*!
     \param left Left side matrix
     \param right Right side matrix
     \return result Result of the matrices multiplication
   */
   virtual Matrix4 multiplyMatrices(const Matrix4 & left, const Matrix4 & right) = 0;

   //! Multiply a point by a matrix (i.e apply the matrix to a point)
   /*!
     \param matrix The matrix to apply
     \param point The point to multiply
     \return result The resulting point
   */
   virtual Point3 multiplyMatrixPoint(const Matrix4 & matrix, const Point3 & point) = 0;

   //! Multiply a vector by a matrix (i.e apply the matrix to a vector)
   /*!
     \param matrix The matrix to apply
     \param vector The vector to multiply
     \return result The resulting point
   */
   virtual Vector3 multiplyMatrixVector(const Matrix4 & matrix, const Vector3 & vector) = 0;

   //! Create an orthographic matrix from a 3D width, a 3D height, a near, and a far clipping distance
   /*!
     \param width3D The 3D width to consider
     \param height3D The 3D height to consider
     \param nearClipDistance The near clipping distance
     \param farClipDistance The far clipping distance
     \return matrix The created matrix
   */
   virtual Matrix4 orthographicMatrix(const CoreI::Double & width3D, const CoreI::Double & height3D, const Distance & nearClipDistance, const Distance & farClipDistance) = 0;

   //! Create a perspective matrix from a fovX, an aspect ratio, a near, and a far clipping distance
   /*!
     \param fovX The field of view on the x axis
     \param aspectRatio The aspect ratio foxX/fovY
     \param nearClipDistance The near clipping distance
     \param farClipDistance The far clipping distance
     \return matrix The created matrix
   */
   virtual Matrix4 perspectiveMatrix(const Angle & fovX, const CoreI::Double & aspectRatio, const Distance & nearClipDistance, const Distance & farClipDistance) = 0;

   //! Decompose a Matrix into translation, rotation and scaling vectors
   /*!
     \param matrix The Matrix to be decomposed
     \return TRS The TRS list
   */
   virtual Vector3List toTRS(const Matrix4 & matrix) = 0;

   /**@}*/

   /**
    * \defgroup debug 
    * @{
    */
   /**@}*/

};

PXZ_MODULE_END



#endif
