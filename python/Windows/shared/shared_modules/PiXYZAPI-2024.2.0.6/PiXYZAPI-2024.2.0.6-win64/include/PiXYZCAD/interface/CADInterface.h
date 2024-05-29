// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CAD_INTERFACE_CADINTERFACE_H_
#define _PXZ_CAD_INTERFACE_CADINTERFACE_H_

#include "CADTypes.h"
#include <PiXYZCAD/interface/ICADInterface.h>

namespace PiXYZ { class PiXYZAPI; }


PXZ_MODULE_BEGIN(CADI)

class PXZ_EXPORTED CADInterface : public ICADInterface
{
public:
   virtual ~CADInterface() {}

   /*!
     \param functionName 
     \param enableFunction 
     \param enableParameters 
     \param enableExecutionTime 
   */
   virtual void configureFunctionLogger(const CoreI::String & functionName, const CoreI::Boolean & enableFunction, const CoreI::Boolean & enableParameters, const CoreI::Boolean & enableExecutionTime) final ;

   //! Get the CAD precision
   /*!
     \return precision The current precision
   */
   virtual GeomI::Distance getPrecision() final ;

   //! Set the CAD unity length property
   /*!
     \param precision Unit length
   */
   virtual void setUnitLength(const GeomI::Distance & precision) final ;


   /**
    * \defgroup Boolean Operators CSG Boolean operator
    * @{
    */
   //! perform boolean operation intersection on two bodies (A ^ B)
   /*!
     \param A The first body
     \param B The second body
     \return result List of resulting bodies
   */
   virtual BodyList solidIntersection(const Body & A, const Body & B) final ;

   //! perform boolean operation subtraction on two bodies (A - B)
   /*!
     \param A The first body
     \param B The second body
     \return result List of resulting bodies
   */
   virtual BodyList solidSubtraction(const Body & A, const Body & B) final ;

   //! perform boolean operation union on two bodies (A + B)
   /*!
     \param A The first body
     \param B The second body
     \return result List of resulting bodies
   */
   virtual BodyList solidUnion(const Body & A, const Body & B) final ;

   /**@}*/

   /**
    * \defgroup curves Curve creation functions
    * @{
    */
   //! Create a Bezier curve
   /*!
     \param poles Poles list
     \return BezierCurve Bezier curve
   */
   virtual Curve createBezierCurve(const GeomI::Point3List & poles) final ;

   //! Create a new circle
   /*!
     \param radius Circle radius
     \param matrix Transformation matrix
     \return circleCurve Generated circle curve
   */
   virtual Curve createCircleCurve(const GeomI::Distance & radius, const GeomI::Matrix4 & matrix) final ;

   //! Create a composite curve from a list of limited curves
   /*!
     \param CurveList List of limited curves
     \return compositeCurve Composite curve created from the list of limited curves
   */
   virtual Curve createCompositeCurve(const CurveList & CurveList) final ;

   //! Create a cosinus curve
   /*!
     \param Amplitude Cosinus amplitude
     \param Offset Cosinus offset
     \param Period Cosinus period
     \param matrix Transformation matrix
     \return cosinusCurve Cosinus curve
   */
   virtual Curve createCosinusCurve(const GeomI::Distance & Amplitude, const GeomI::Distance & Offset, const GeomI::Distance & Period, const GeomI::Matrix4 & matrix) final ;

   //! Create an ellipse curve
   /*!
     \param URadius Ellipse radius in u direction
     \param VRadius Ellipse radius in v direction
     \param matrix Transformation matrix
     \return ellipseCurve Ellipse curve
   */
   virtual Curve createEllipseCurve(const GeomI::Distance & URadius, const GeomI::Distance & VRadius, const GeomI::Matrix4 & matrix) final ;

   //! Create an helix curve
   /*!
     \param radius Radius of the helix
     \param pitch Height of one revolution
     \param matrix Transformation matrix
     \param trigonometrixOrientation Orientation of the rotation
     \return helixCurve Helix curve
   */
   virtual Curve createHelixCurve(const GeomI::Distance & radius, const GeomI::Distance & pitch, const GeomI::Matrix4 & matrix, const CoreI::Boolean & trigonometrixOrientation = true) final ;

   //! Create a Hermite Curve
   /*!
     \param FirstPoint Starting point of the curve
     \param FirstTangent Tangent of the starting point
     \param SecondPoint Ending point of the curve
     \param SecondTangent Tangent of the ending point
     \return HermiteCurve Hermite curve
   */
   virtual Curve createHermiteCurve(const GeomI::Point3 & FirstPoint, const GeomI::Point3 & FirstTangent, const GeomI::Point3 & SecondPoint, const GeomI::Point3 & SecondTangent) final ;

   //! Create an hyperBola curve
   /*!
     \param URadius Hyperbola radius in u direction
     \param VRadius Hyperbola radius in v direction
     \param matrix Transformation matrix
     \return parabolaCurve Hyperbola curve
   */
   virtual Curve createHyperbolaCurve(const CoreI::Double & URadius, const CoreI::Double & VRadius, const GeomI::Matrix4 & matrix) final ;

   //! Create a Intersection Curve
   /*!
     \param firstSurface First surface of the intersection curve
     \param secondSurface Second surface of the intersection curve
     \param chart Direction curve of the intersection curve
     \param minBounds Minimum value of the bounds of the intersection curve
     \param maxBounds Maximum value of the bounds of the intersection curve
     \return IntersectionCurve Intersection curve
   */
   virtual Curve createIntersectionCurve(const Surface & firstSurface, const Surface & secondSurface, const PolylineCurve & chart, const CoreI::Double & minBounds, const CoreI::Double & maxBounds) final ;

   //! Create a Line Curve
   /*!
     \param OriginPt Orinin point of the line curve
     \param DirectionPt Direction vector of the line curve
     \return LineCurve Line curve
   */
   virtual Curve createLineCurve(const GeomI::Point3 & OriginPt, const GeomI::Point3 & DirectionPt) final ;

   //! Create a NURBS curve
   /*!
     \param degree Degree of the curve
     \param knots Knots of the curve
     \param poles Poles list
     \param weights Weight list
     \return NURBSCurve NURBS curve
   */
   virtual Curve createNURBSCurve(const CoreI::Int & degree, const CoreI::DoubleList & knots, const GeomI::Point3List & poles, const CoreI::DoubleList & weights = CoreI::DoubleList(0)) final ;

   //! Create an parabola curve
   /*!
     \param focalLength Focal lecngth of the parabola
     \param matrix Transformation matrix
     \return parabolaCurve Parabola curve
   */
   virtual Curve createParabolaCurve(const CoreI::Double & focalLength, const GeomI::Matrix4 & matrix) final ;

   //! Create a Polyline curve
   /*!
     \param points Points of polyline curve
     \param parameters Params of polyline curve
     \return polylineCurve Polyline curve
   */
   virtual Curve createPolylineCurve(const GeomI::Point3List & points, const CoreI::DoubleList & parameters = CoreI::DoubleList(0)) final ;

   //! Create a segment curve from two given points
   /*!
     \param firstPoint First point
     \param secondPoint Second point
     \return segmentCurve Segment curve created from the two given points
   */
   virtual Curve createSegmentCurve(const GeomI::Point3 & firstPoint, const GeomI::Point3 & secondPoint) final ;

   //! Create a curve from a surface
   /*!
     \param surface Surface to bound
     \param curve2D Curve to project
     \return surfacicCurve Curve projected on given surface
   */
   virtual Curve createSurfacicCurve(const Surface & surface, const Curve & curve2D) final ;

   //! Create a curve from a surface
   /*!
     \param curve Curve to transform
     \param matrix Matrix of the transformation
     \return transformedCurve Curve transformed by the given matrix
   */
   virtual Curve createTransformedCurve(const Curve & curve, const GeomI::Matrix4 & matrix) final ;

   //! Invert a curve parametricaly
   /*!
     \param curve The curve to invert
     \param precision The precision used to invert the curve
     \return invertedCurve The inverted curve
   */
   virtual Curve invertCurve(const Curve & curve, const CoreI::Double & precision) final ;

   /**@}*/

   /**
    * \defgroup extrusion creation CAD extrusion creation functions
    * @{
    */
   //! create a revolved extrusion
   /*!
     \param profileCurves Profile curves to revolve
     \param center The center of revolution
     \param direction The profile curves will be revolved in this direction
     \param angle The revolution will stop at the defined angle
     \param area If the profile curves define an area or not
     \return revolvedExtrusion The created body
   */
   virtual Body createRevolveExtrusion(const CurveList & profileCurves, const GeomI::Point3 & center, const GeomI::Vector3 & direction, const CoreI::Double & angle, const CoreI::Bool & area) final ;

   /**@}*/

   /**
    * \defgroup material 
    * @{
    */
   //! get the material on a face
   /*!
     \param face The face
     \return material The material
   */
   virtual MaterialI::Material getFaceMaterial(const Face & face) final ;

   //! set the material on a face
   /*!
     \param face The face
     \param material The material
   */
   virtual void setFaceMaterial(const Face & face, const MaterialI::Material & material) final ;

   /**@}*/

   /**
    * \defgroup model management CAD model management functions
    * @{
    */
   //! Add a body to the model
   /*!
     \param body Body added to the model
     \param model Model
   */
   virtual void addBodyToModel(const Body & body, const Model & model) final ;

   //! Add an edge to the model
   /*!
     \param edge Edge added to the model
     \param model Model
   */
   virtual void addEdgeToModel(const Edge & edge, const Model & model) final ;

   //! Add an open shell to the model
   /*!
     \param shell Open shell added to the model
     \param model Model
   */
   virtual void addOpenShellToModel(const OpenShell & shell, const Model & model) final ;

   //! Add a vertex to the model
   /*!
     \param vtx Vertex added to the model
     \param model Model
   */
   virtual void addVertexToModel(const Vertex & vtx, const Model & model) final ;

   //! Build faces from a surface and a set of loop
   /*!
     \param surface Surface used to build the faces
     \param loopList List of Loops used to build the faces
     \return faces The created faces
     \return splittingInfo Map between the old edges and the new ones
   */
   virtual buildFacesReturn buildFaces(const Surface & surface, const LoopList & loopList) final ;

   //! Create a new model
   /*!
     \param precision CAD precision for this model
     \return model The created model
   */
   virtual Model createModel(const GeomI::Distance & precision = -1) final ;

   //! Create a new BrepSession on current thread
   virtual void endThreadBrepSession() final ;

   //! Get all the face of a model recursively
   /*!
     \param model Model
     \return faces List of faces in the given model
   */
   virtual FaceList getAllModelFaces(const Model & model) final ;

   //! Get the list of bodies contained in a model
   /*!
     \param model Model
     \return bodies List of bodies contained in the given model
   */
   virtual BodyList getModelBodies(const Model & model) final ;

   //! Get boundary edges of a model grouped by cycles
   /*!
     \param model Model
     \return boundaries List of boundary edges grouped by cycles in the given model
   */
   virtual EdgeListList getModelBoundaries(const Model & model) final ;

   //! Get the list of free edges contained in a model
   /*!
     \param model Model
     \return edges List of edges contained in the given model
   */
   virtual EdgeList getModelEdges(const Model & model) final ;

   //! Get the list of open shells contained in a model
   /*!
     \param model Model
     \return shells List of open shells contained in the given model
   */
   virtual OpenShellList getModelOpenShells(const Model & model) final ;

   //! Get the list of free vertices contained in a model
   /*!
     \param model Model
     \return vertices List of vertices contained in the given model
   */
   virtual VertexList getModelVertices(const Model & model) final ;

   //! Returns the entities referencing a given CAD entity
   /*!
     \param entity CAD entity to get the referencers
     \return referencers List of CAD entities referencing the given entity
   */
   virtual CoreI::EntityList getReferencers(const CADEntity & entity) final ;

   //! Create a new BrepSession on current thread
   /*!
     \param precision CAD precision for this model
   */
   virtual void startThreadBrepSession(const GeomI::Distance & precision) final ;

   /**@}*/

   /**
    * \defgroup primitives CAD primitives creation functions
    * @{
    */
   //! Creates a BRep Cone whose axis is the Z axis centered on O
   /*!
     \param radius Cone radius
     \param height Cone height
     \param matrix Positionning matrix of the Cone
     \return body The created Body
   */
   virtual Body createBRepCone(const CoreI::Double & radius, const CoreI::Double & height, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Creates a BRep Cube
   /*!
     \param size Side length
     \param matrix Positionning matrix of the Cube
     \return body The created Body
   */
   virtual Body createBRepCube(const CoreI::Double & size, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Creates a BRep Cylinder aligned on the Z axis centered on O
   /*!
     \param radius Cylinder radius
     \param length Cylinder length
     \param matrix Positionning matrix of the Cylinder
     \return body The created Body
   */
   virtual Body createBRepCylinder(const CoreI::Double & radius, const CoreI::Double & length, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Creates a BRep Plane whose normal is the Z axis centered on O
   /*!
     \param length Plane length (X axis)
     \param width Plane width (Y axis)
     \param matrix Positionning matrix of the Plane
     \return body The created Body
   */
   virtual Body createBRepPlane(const CoreI::Double & length, const CoreI::Double & width, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Creates a BRep Sphere centered on O and whose singularities are on the Z axis
   /*!
     \param radius Sphere radius
     \param matrix Positionning matrix of the Sphere
     \return body The created Body
   */
   virtual Body createBRepSphere(const CoreI::Double & radius, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Creates a BRep Torus whose axis is the Z axis centered on O
   /*!
     \param majorRadius Major radius
     \param minorRadius Minor radius
     \param matrix Positionning matrix of the Torus
     \return body The created Body
   */
   virtual Body createBRepTorus(const CoreI::Double & majorRadius, const CoreI::Double & minorRadius, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Creates a BRep Lego brick
   /*!
     \param brickDefinition The definition of the wanted lego brick
     \return body The created Body
   */
   virtual Body createLegoBrick(const LegoBrickDefinition & brickDefinition) final ;

   /**@}*/

   /**
    * \defgroup structure access CAD structure access functions
    * @{
    */
   //! evaluate curvature on a curve
   /*!
     \param curve The curve
     \param parameter Parameter to evaluate
     \return curvature Curvature on curve at parameter
   */
   virtual CoreI::Double evalCurvatureOnCurve(const Curve & curve, const CoreI::Double & parameter) final ;

   //! evaluate main curvatures on a surface
   /*!
     \param surface The surface
     \param parameter Parameter to evaluate
     \return curvatures Main curvatures on surface at parameter
   */
   virtual GeomI::Curvatures evalCurvatureOnSurface(const Surface & surface, const GeomI::Point2 & parameter) final ;

   //! evaluate a point and derivatives on a curve
   /*!
     \param curve The curve
     \param parameter Parameter to evaluate
     \param derivation Derivation level (0,1,2)
     \return d0 D0
     \return du Du
     \return d2u D2u
   */
   virtual evalOnCurveReturn evalOnCurve(const Curve & curve, const CoreI::Double & parameter, const CoreI::Int & derivation = 0) final ;

   //! evaluate a point and derivatives on a surface
   /*!
     \param surface The surface
     \param parameter Parameter to evaluate
     \param derivation Derivation level (0,1,2)
     \return d0 D0
     \return du Du
     \return dv Dv
     \return d2u D2u
     \return d2v D2v
     \return duv Duv
   */
   virtual evalOnSurfaceReturn evalOnSurface(const Surface & surface, const GeomI::Point2 & parameter, const CoreI::Int & derivation = 0) final ;

   //! get all closedShells contain in the body
   /*!
     \param body The body
     \return closedShells The closedShells contain within the body
   */
   virtual ClosedShellList getBodyClosedShells(const Body & body) final ;

   //! get all parameters contained in the circleCurve
   /*!
     \param circleCurve The circleCurve
     \return radius The radius of the circle
     \return matrix The matrix transformation of the circle
   */
   virtual getCircleCurveDefinitionReturn getCircleCurveDefinition(const CircleCurve & circleCurve) final ;

   //! get all orienteFaces contain in the closedShell
   /*!
     \param closedShell The closedShell
     \return orientedFaces The orientedFaces contain within the closedShell
   */
   virtual OrientedFaceList getClosedShellOrientedFaces(const ClosedShell & closedShell) final ;

   //! get all parameters contained in the coEdge
   /*!
     \param coEdge The coEdge
     \return edge The edge of the coEdge
     \return edgeOrientation Orientation of the edge
     \return loop The loop containing the coEdge
     \return surface The surface of the coEdge
     \return parametricCurve The parametricCurve of the coEdge
   */
   virtual getCoEdgeDefinitionReturn getCoEdgeDefinition(const CoEdge & coEdge) final ;

   //! get all parameters contained in the compositeCurve
   /*!
     \param compositeCurve The compositeCurve
     \return curves The curves of the compositeCurve
     \return parameters The parameters of the compositeCurve
   */
   virtual getCompositeCurveDefinitionReturn getCompositeCurveDefinition(const CompositeCurve & compositeCurve) final ;

   //! get all parameters contained in the coneSurface
   /*!
     \param coneSurface The coneSurface
     \return radius The radius of the coneSurface
     \return semiAngle The semiAngle of coneSurface
     \return matrix The transformation matrix of coneSurface
   */
   virtual getConeSurfaceDefinitionReturn getConeSurfaceDefinition(const ConeSurface & coneSurface) final ;

   //! get all parameters contained in the curveExtrusionSurface
   /*!
     \param curveExtrusionSurface The curveExtrusionSurface
     \return generatrixCurve The generatrix curve of the curveExtrusionSurface
     \return directrixCruve The directrix curve of the curveExtrusionSurface
     \return surfaceReference The reference surface of curveExtrusionSurface
   */
   virtual getCurveExtrusionSurfaceDefinitionReturn getCurveExtrusionSurfaceDefinition(const CurveExtrusionSurface & curveExtrusionSurface) final ;

   //! returns the length of the curve
   /*!
     \param curve The curve
     \return length The length of the edge
   */
   virtual CoreI::Double getCurveLength(const Curve & curve) final ;

   //! get the parametric space limits of a curve
   /*!
     \param curve The curve
     \return limits Curve limits
   */
   virtual Bounds1D getCurveLimits(const Curve & curve) final ;

   //! get all parameters contained in the cylinderSurface
   /*!
     \param cylinderSurface The cylinderSurface
     \return radius The radius of the cylinderSurface
     \return matrix The transformation matrix of cylinderSurface
   */
   virtual getCylinderSurfaceDefinitionReturn getCylinderSurfaceDefinition(const CylinderSurface & cylinderSurface) final ;

   //! get all parameters contained in the edge
   /*!
     \param edge The edge
     \return vertex1 The first vertex of the edge
     \return vertex2 The second vertex of the edge
     \return curve The curve of the edge
     \return bounds The bounds of the edge
   */
   virtual getEdgeDefinitionReturn getEdgeDefinition(const Edge & edge) final ;

   //! returns the length of the edge
   /*!
     \param edge The edge
     \return length The length of the edge
   */
   virtual CoreI::Double getEdgeLength(const Edge & edge) final ;

   //! get all parameters contained in the ellipseCurve
   /*!
     \param ellipseCurve The ellipseCurve
     \return radius1 The radius on x of the ellipse
     \return radius2 The radius on y of the ellipse
     \return matrix The transformation matrix of the ellipse
   */
   virtual getEllipseCurveDefinitionReturn getEllipseCurveDefinition(const EllipseCurve & ellipseCurve) final ;

   //! get all parameters contained in the ellipticConeSurface
   /*!
     \param ellipticConeSurface The EllipticConeSurface
     \return radius1 The radius on X of the coneSurface
     \return radius2 The radius on Y of the coneSurface
     \return semiAngle The semiAngle of coneSurface
     \return matrix The transformation matrix of coneSurface
   */
   virtual getEllipticConeSurfaceDefinitionReturn getEllipticConeSurfaceDefinition(const EllipticConeSurface & ellipticConeSurface) final ;

   //! get all parameters contain in the face
   /*!
     \param face The face
     \return surface The surface contain within the face
     \return loops The loops contain within the face
     \return orientation Relative orientation of the surface
     \return limits Face limits on surfaces
   */
   virtual getFaceDefinitionReturn getFaceDefinition(const Face & face) final ;

   //! get parametric definition of each face loop
   /*!
     \param face The face
     \return boundaries The parametric boundaries
   */
   virtual GeomI::Point2ListList getFaceParametricBoundaries(const Face & face) final ;

   //! get all parameters contained in the helixCurve
   /*!
     \param helixCurve The helixCurve
     \return radius The radius of the helixCurve
     \return matrix The matrix of the helixCurve
     \return trigonometricOrientation The trigonometricOrientation of the helixCurve
   */
   virtual getHelixCurveDefinitionReturn getHelixCurveDefinition(const HelixCurve & helixCurve) final ;

   //! get all parameters contained in the hermiteCurve
   /*!
     \param hermiteCurve The HermiteCurve
     \return firstPoint The first point of the hermiteCurve
     \return secondPoint The second point of the hermiteCurve
     \return firstTangent The first tangent of the hermiteCurve
     \return secondTangent The second tangent of the hermiteCurve
   */
   virtual getHermiteCurveDefinitionReturn getHermiteCurveDefinition(const HermiteCurve & hermiteCurve) final ;

   //! get all parameters contained in the hyperbolaCurve
   /*!
     \param hyperbolaCurve The hyperbolaCurve
     \return radius1 The radius on x of the hyperbola
     \return radius2 The radius on y of the hyperbola
     \return matrix The transformation matrix of the hyperbola
   */
   virtual getHyperbolaCurveDefinitionReturn getHyperbolaCurveDefinition(const HyperbolaCurve & hyperbolaCurve) final ;

   //! get all parameters contained in the intersectionCurve
   /*!
     \param intersectionCurve The intersectionCurve
     \return surface1 The first surface of the intersectionCurve
     \return surface2 The second surface of the intersectionCurve
     \return chart The chart of the intersectionCurve
     \return bounds The boudns of the intersectionCurve
   */
   virtual getIntersectionCurveDefinitionReturn getIntersectionCurveDefinition(const IntersectionCurve & intersectionCurve) final ;

   //! get all parameters contain in the lineCurve
   /*!
     \param lineCurve The lineCurve
     \return origin The origin of the lineCurve
     \return direction The direction of the lineCurve
   */
   virtual getLineCurveDefinitionReturn getLineCurveDefinition(const LineCurve & lineCurve) final ;

   //! get all coEdges contain in the loop
   /*!
     \param loop The loop
     \return coEdges The coEdges contain within the loop
   */
   virtual CoEdgeList getLoopCoEdges(const Loop & loop) final ;

   //! get all parameters contained in the nurbsCurve
   /*!
     \param nurbsCurve The nurbsCurve
     \return degree The degree of the nurbsCurve
     \return knots The knots of the nurbsCurve
     \return poles The poles of the nurbsCurve
     \return weights The weights of the poles of the nurbsCurve
   */
   virtual getNURBSCurveDefinitionReturn getNURBSCurveDefinition(const NURBSCurve & nurbsCurve) final ;

   //! get all parameters contained in the nurbsSurface
   /*!
     \param nurbsSurface The nurbsSurface
     \return degreeU The degree on U of the nurbsSurface
     \return degreeV The degree on V of the nurbsSurface
     \return knotsU The knots on U of the nurbsSurface
     \return knotsV The knots on V of the nurbsSurface
     \return poles The poles of nurbsSurface
     \return weights The weights of the poles of nurbsSurface
   */
   virtual getNURBSSurfaceDefinitionReturn getNURBSSurfaceDefinition(const NURBSSurface & nurbsSurface) final ;

   //! get all parameters contained in the offsetCurve
   /*!
     \param offsetCurve The offsetCurve
     \return curve The curve of the offsetCurve
     \return direction The direction of the offset
     \return distance The distance of the offset
     \return surfaceReference The surfaceReference of the offsetCurve
   */
   virtual getOffsetCurveDefinitionReturn getOffsetCurveDefinition(const OffsetCurve & offsetCurve) final ;

   //! get all parameters contained in the offsetSurface
   /*!
     \param offsetSurface The offsetSurface
     \return baseSurface The initial surface
     \return distance The distance offset
   */
   virtual getOffsetSurfaceDefinitionReturn getOffsetSurfaceDefinition(const OffsetSurface & offsetSurface) final ;

   //! get all orienteFaces contain in the openShell
   /*!
     \param openShell The openShell
     \return orientedFaces The orientedFaces contain within the openShell
   */
   virtual OrientedFaceList getOpenShellOrientedFaces(const OpenShell & openShell) final ;

   //! get all parameters contained in the parabolaCurve
   /*!
     \param parabolaCurve The parabolaCurve
     \return focalLength The radius of the hyperbola
     \return matrix The transformation matrix of the hyperbola
   */
   virtual getParabolaCurveDefinitionReturn getParabolaCurveDefinition(const ParabolaCurve & parabolaCurve) final ;

   //! returns the parametric precision of a surface from the input precision
   /*!
     \param surface The surface
     \param precision Input precision
     \return parametricPrecision 
   */
   virtual CoreI::Double getParametricPrecisionOnSurface(const Surface & surface, const CoreI::Double & precision) final ;

   //! get all parameters contained in the planeSurface
   /*!
     \param planeSurface The planeSurface
     \return matrix The transformation matrix of planeSurface
   */
   virtual GeomI::Matrix4 getPlaneSurfaceDefinition(const PlaneSurface & planeSurface) final ;

   //! get all parameters contained in the polylinCurve
   /*!
     \param polylineCurve The polylineCurve
     \return points The points of the polylineCurve
     \return parameters The parameters of the polylineCurve
   */
   virtual getPolylineCurveDefinitionReturn getPolylineCurveDefinition(const PolylineCurve & polylineCurve) final ;

   //! get all parameters contained in the revolutionSurface
   /*!
     \param revolutionSurface The revolutionSurface
     \return generatricCurve Thegeneratrix curve of the revolutionSurface
     \return axisOrigin The origin of the axis of the revolutionSurface
     \return axisDirection The direction of the axis of the revolutionSurface
     \return startAngle The starting angle of the revolutionSurface
     \return endAngle The ending angle of the revolutionSurface
   */
   virtual getRevolutionSurfaceDefinitionReturn getRevolutionSurfaceDefinition(const RevolutionSurface & revolutionSurface) final ;

   //! get all parameters contained in the ruledSurface
   /*!
     \param ruledSurface The ruledSurface
     \return firstCurve The first curve of the ruledSurface
     \return secondCurve The second curve of the ruledSurface
   */
   virtual getRuledSurfaceDefinitionReturn getRuledSurfaceDefinition(const RuledSurface & ruledSurface) final ;

   //! get all parameters contained in the segmentCurve
   /*!
     \param segmentCurve The segmentCurve
     \return startPoint The first point of the segmentCurve
     \return endPoint The second point of the segmentCurve
   */
   virtual getSegmentCurveDefinitionReturn getSegmentCurveDefinition(const SegmentCurve & segmentCurve) final ;

   //! get all parameters contained in the sphereSurface
   /*!
     \param sphereSurface The sphereSurface
     \return radius The radius of the sphereSurface
     \return matrix The transformation matrix of sphereSurface
   */
   virtual getSphereSurfaceDefinitionReturn getSphereSurfaceDefinition(const SphereSurface & sphereSurface) final ;

   //! get the parametric space limits of a surface
   /*!
     \param surface The surface
     \return limits Surface limits
   */
   virtual Bounds2D getSurfaceLimits(const Surface & surface) final ;

   //! get all parameters contained in the surfacicCurve
   /*!
     \param surfacicCurve The surfacicCurve
     \return surface The surface of the surfacicCurve
     \return curve2D The 2D curve of the surfacicCurve
   */
   virtual getSurfacicCurveDefinitionReturn getSurfacicCurveDefinition(const SurfacicCurve & surfacicCurve) final ;

   //! get all parameters contained in the TabulatedCylinderSurface
   /*!
     \param tabulatedCylinderSurface The tabulatedCylinderSurface
     \return directrixCurve The directrix curve of the tabulatedCylinderSurface
     \return generatrixLine The generatrix line of the tabulatedCylinderSurface
     \return range The range of the tabulatedCylinderSurface
   */
   virtual getTabulatedCylinderSurfaceDefinitionReturn getTabulatedCylinderSurfaceDefinition(const TabulatedCylinderSurface & tabulatedCylinderSurface) final ;

   //! get all parameters contained in the torusSurface
   /*!
     \param torusSurface The torusSurface
     \return majorRadius The major radius of the torusSurface
     \return minorRadius The minor radius of the torusSurface
     \return matrix The transformation matrix of torusSurface
     \return type The torus shape type id
   */
   virtual getTorusSurfaceDefinitionReturn getTorusSurfaceDefinition(const TorusSurface & torusSurface) final ;

   //! get all parameters contained in the transformedCurve
   /*!
     \param transformedCurve The transformedCurve
     \return curve The initial curve
     \return matrix The transformation matrix
   */
   virtual getTransformedCurveDefinitionReturn getTransformedCurveDefinition(const TransformedCurve & transformedCurve) final ;

   //! get the position of the vertex
   /*!
     \param vertex The vertex
     \return position The position of the vertex
   */
   virtual GeomI::Point3 getVertexPosition(const Vertex & vertex) final ;

   //! invert a point to a curve
   /*!
     \param curve The curve
     \param point The point to invert
     \param precision Inversion precision
     \return parameter The inversion parameter on the curve
   */
   virtual CoreI::Double invertOnCurve(const Curve & curve, const GeomI::Point3 & point, const CoreI::Double & precision = -1) final ;

   //! invert a point to a surface
   /*!
     \param surface The surface
     \param point The point to invert
     \param precision Inversion precision
     \return parameter The inversion parameter on the surface
   */
   virtual GeomI::Point2 invertOnSurface(const Surface & surface, const GeomI::Point3 & point, const CoreI::Double & precision = -1) final ;

   //! if the curve is closed, return true, return false otherwise
   /*!
     \param curve The curve
     \return closed The value
   */
   virtual CoreI::Boolean isCurveClosed(const Curve & curve) final ;

   //! if the curve is finite return true, return false otherwise
   /*!
     \param curve The curve
     \return finite The value
   */
   virtual CoreI::Boolean isCurveFinite(const Curve & curve) final ;

   //! if the curve is periodic return true, return false otherwise
   /*!
     \param curve The curve
     \return periodic The value
     \return period If th curve is periodic, this value is equal to the period value, equal to 0 otherwise
   */
   virtual isCurvePeriodicReturn isCurvePeriodic(const Curve & curve) final ;

   //! return if the surface is closed on U or on V
   /*!
     \param surface The surface
     \return closedU The value on U
     \return closedV The value on V
   */
   virtual isSurfaceClosedReturn isSurfaceClosed(const Surface & surface) final ;

   //! return if the surface is periodic on U or on V
   /*!
     \param surface The surface
     \return periodicU The value on U
     \return periodicV The value on V
     \return periodU If th curve is periodic on U, this value is equal to the period value, equal to 0 otherwise
     \return periodV If th curve is periodic on V, this value is equal to the period value, equal to 0 otherwise
   */
   virtual isSurfacePeriodicReturn isSurfacePeriodic(const Surface & surface) final ;

   /*!
     \param surface The surface
     \param points List of points to check the surface
     \return result Result of the check
   */
   virtual CoreI::Boolean needTorusShapeCheck(const Surface & surface, const GeomI::Point3List & points) final ;

   //! project a point to a curve
   /*!
     \param curve The curve
     \param point The point to project
     \param precision Projection precision
     \return projectionParameter The projection parameter on the curve
   */
   virtual CoreI::Double projectOnCurve(const Curve & curve, const GeomI::Point3 & point, const CoreI::Double & precision = -1) final ;

   //! project a point to a surface
   /*!
     \param surface The surface
     \param point The point to project
     \param precision Projection precision
     \return projectionParameter The projection parameter on the surface
   */
   virtual GeomI::Point2 projectOnSurface(const Surface & surface, const GeomI::Point3 & point, const CoreI::Double & precision = -1) final ;

   //! Set the curve 2D value of a coEdge
   /*!
     \param coEdge The coEdge
     \param curve2D The new curve 2D
   */
   virtual void setCoEdgeCurve2D(const CoEdge & coEdge, const Curve & curve2D) final ;

   //! Set the surface value of a coEdge
   /*!
     \param coEdge The coEdge
     \param surface The new surface
   */
   virtual void setCoEdgeSurface(const CoEdge & coEdge, const Surface & surface) final ;

   //! set the parametric space limits of a curve
   /*!
     \param curve The curve
     \param limits Curve limits
   */
   virtual void setCurveLimits(const Curve & curve, const Bounds1D & limits) final ;

   //! Define an edge's edge style
   /*!
     \param edge The edge to apply to style to
     \param style The EdgeStyle to apply
   */
   virtual void setEdgeStyle(const Edge & edge, const EdgeStyle & style) final ;

   /**@}*/

   /**
    * \defgroup structure creation CAD structure creation functions
    * @{
    */
   //! Create a body from a surface
   /*!
     \param outerShell ClosedShell used to create the body
     \param innerShells List of closedShell used to create the body
     \return body The created body
   */
   virtual Body createBody(const ClosedShell & outerShell, const ClosedShellList & innerShells = ClosedShellList(0)) final ;

   //! Create a closedShell from a set of faces of a set of orientations
   /*!
     \param faces List of faces composing the closedShell
     \param orientations List of orientations for each face
     \return closedShell The created closedShell
   */
   virtual ClosedShell createClosedShell(const FaceList & faces, const GeomI::OrientationList & orientations) final ;

   //! Create an coEdge with a edge and an orientation
   /*!
     \param edge Edge used to create the coEdge
     \param orientation Orientation of the edge regarding the loop
     \param surface The surface trimmed by the edge
     \param curve2D Surfacic curve of the edge on the surface trimmed
     \return coEdge The created edge
   */
   virtual CoEdge createCoEdge(const Edge & edge, const GeomI::Orientation & orientation, const Surface & surface = 0, const Curve & curve2D = 0) final ;

   //! Create an edge with a curve an extremity vertices
   /*!
     \param curve Curve used to create the edge
     \param startVertex The start vertex
     \param endVertex The end vertex
     \return edge The created edge
   */
   virtual Edge createEdge(const Curve & curve, const Vertex & startVertex, const Vertex & endVertex) final ;

   //! Create an edge from a limited curve
   /*!
     \param curve Limited curve used to create the edge
     \return edge The created edge
   */
   virtual Edge createEdgeFromCurve(const Curve & curve) final ;

   //! Create a face from a surface
   /*!
     \param surface Surface used to create the face
     \param loopList List of Loops used to create the face
     \param useSurfaceOrientation If True, the face will have the same orientation than the surface and loops will be inverted if they are inconsistent
     \return face The created face
   */
   virtual Face createFace(const Surface & surface, const LoopList & loopList = LoopList(0), const CoreI::Boolean & useSurfaceOrientation = false) final ;

   //! Create a loop from a set of edges of a set of orientations
   /*!
     \param coEdges List of coEdges composing the loop
     \param check If true, the loop check if edges are well connected or not
     \return loop The created loop
   */
   virtual Loop createLoop(const CoEdgeList & coEdges, const CoreI::Boolean & check = true) final ;

   //! Create a openShell from a set of faces of a set of orientations and set of loops
   /*!
     \param faces List of faces composing the openShell
     \param orientations List of orientations for each face
     \return openShell The created openShell
   */
   virtual OpenShell createOpenShell(const FaceList & faces, const GeomI::OrientationList & orientations) final ;

   //! Create a vertex from a position
   /*!
     \param position Vertex position
     \return vertex The created vertex
   */
   virtual Vertex createVertex(const GeomI::Point3 & position) final ;

   //! Invert a coedge
   /*!
     \param coedge The coedge to invert
   */
   virtual void invertCoEdge(const CoEdge & coedge) final ;

   //! Invert faces
   /*!
     \param faces The faces to invert
   */
   virtual void invertFaces(const FaceList & faces) final ;

   //! Invert a loop
   /*!
     \param loop The loop to invert
   */
   virtual void invertLoop(const Loop & loop) final ;

   //! return if the surface is finite
   /*!
     \param surface The surface
     \return finite Tells if finite
   */
   virtual CoreI::Boolean isSurfaceFinite(const Surface & surface) final ;

   /**@}*/

   /**
    * \defgroup surfaces Surface creation functions
    * @{
    */
   /*!
     \param surface Surface on which the precision area will be set
     \param aabr 2D area defining the working area
   */
   virtual void addPrecisionArea(const Surface & surface, const GeomI::AABR & aabr) final ;

   //! Create a new bezier surface
   /*!
     \param degreeU U degree
     \param degreeV V degree
     \param poles Poles list
     \return bezierSurface The new Bezier surface
   */
   virtual Surface createBezierSurface(const CoreI::Int & degreeU, const CoreI::Int & degreeV, const GeomI::Point3List & poles) final ;

   //! Create a new cone surface
   /*!
     \param radius Radius of the cone at origin
     \param semiAngle Semi-angle of the cone
     \param matrix Positionning matrix of the cone
     \return coneSurface The new cone surface
   */
   virtual Surface createConeSurface(const GeomI::Distance & radius, const GeomI::Angle & semiAngle, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Create a new curveExtrusion surface
   /*!
     \param generatrixCurve The generatrix curve
     \param directrixCurve The directrix curve
     \param refSurface The reference surface
     \return curveExtrusionSurface The new curveExtrusion surface
   */
   virtual Surface createCurveExtrusionSurface(const Curve & generatrixCurve, const Curve & directrixCurve, const Surface & refSurface) final ;

   //! Create a new cylinder surface
   /*!
     \param radius Radius of the cylinder
     \param matrix Positionning matrix of the cylinder
     \return cylinderSurface The new cylinder surface
   */
   virtual Surface createCylinderSurface(const GeomI::Distance & radius, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Create a new elliptic cone surface
   /*!
     \param radius1 Radius of the cone at origin on the X axis
     \param radius2 Radius of the cone at origin on the Y axis
     \param semiAngle Semi-angle of the cone
     \param matrix Positionning matrix of the cone
     \return ellipticConeSurface The new elliptic cone surface
   */
   virtual Surface createEllipticConeSurface(const GeomI::Distance & radius1, const GeomI::Distance & radius2, const GeomI::Angle & semiAngle, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Create a new NURBS surface
   /*!
     \param degreeU U degree
     \param degreeV V degree
     \param knotsU Knots on U
     \param knotsV Knots on V
     \param poles Poles list
     \param weights Weights list
     \return NURBSSurface The new NURBS surface
   */
   virtual Surface createNURBSSurface(const CoreI::Int & degreeU, const CoreI::Int & degreeV, const CoreI::DoubleList & knotsU, const CoreI::DoubleList & knotsV, const GeomI::Point3List & poles, const CoreI::DoubleList & weights = CoreI::DoubleList(0)) final ;

   //! Create a new offset surface
   /*!
     \param baseSurface The base surface
     \param distance The offset distance
     \return offsetSurface The new offset surface
   */
   virtual Surface createOffsetSurface(const Surface & baseSurface, const CoreI::Double & distance) final ;

   //! Create a new plane surface
   /*!
     \param matrix Positionning matrix of the plane
     \return planeSurface The new plane surface
   */
   virtual Surface createPlaneSurface(const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Create a new revolution surface
   /*!
     \param generatrixCurve Generatrix curve rotated to create the revolution surface
     \param axisOrigin Axis origin point
     \param axisDirection Axis direction vector
     \param startAngle Start angle of the revolution surface
     \param endAngle End angle of the revolution surface
     \return revolutionSurface Revolution surface generated by rotating the given curve around the axis
   */
   virtual Surface createRevolutionSurface(const Curve & generatrixCurve, const GeomI::Point3 & axisOrigin, const GeomI::Vector3 & axisDirection, const GeomI::Angle & startAngle = 0, const GeomI::Angle & endAngle = 360.0) final ;

   //! Create a new ruled surface
   /*!
     \param firstCurve First Curve
     \param secondCurve Seconde Curve
     \return ruledSurface The new ruled surface
   */
   virtual Surface createRuledSurface(const Curve & firstCurve, const Curve & secondCurve) final ;

   //! Create a new sphere surface
   /*!
     \param radius Radius of the sphere
     \param matrix Positionning matrix of the sphere
     \return sphereSurface The new sphere surface
   */
   virtual Surface createSphereSurface(const GeomI::Distance & radius, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! Create a new tabulated cylinder surface
   /*!
     \param directrixCurve Directrix Curve
     \param GeneratixLine Generatrix Line
     \param minRange Minimimum value of the range
     \param maxRange Maximum value of the range
     \return tabulatedCylinderSurface The new tabulated cylinder surface
   */
   virtual Surface createTabulatedCylinderSurface(const Curve & directrixCurve, const GeomI::Point3 & GeneratixLine, const GeomI::Distance & minRange, const GeomI::Distance & maxRange) final ;

   //! Create a new torus surface
   /*!
     \param radiusMax Major radius 
     \param radiusMin Minor radius 
     \param matrix Positionning matrix of the sphere
     \return torusSurface The new torus surface
   */
   virtual Surface createTorusSurface(const GeomI::Distance & radiusMax, const GeomI::Distance & radiusMin, const GeomI::Matrix4 & matrix = GeomI::IdentityMatrix4()) final ;

   //! tells if it needs a working area on the surface
   /*!
     \param surface Surface to check if it needs precision area
     \return need Result
   */
   virtual CoreI::Boolean needPrecisionArea(const Surface & surface) final ;

   /**@}*/

private:
   friend class PiXYZ::PiXYZAPI;
   CADInterface(void * session);
   void * _session;
};

PXZ_MODULE_END



#endif
