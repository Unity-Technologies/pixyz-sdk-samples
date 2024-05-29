// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CAD_INTERFACE_CADINTERFACE_C_H_
#define _PXZ_CAD_INTERFACE_CADINTERFACE_C_H_

#include "CADTypes_c.h"

PXZ_EXPORTED char * CAD_getLastError();

PXZ_EXPORTED void CAD_configureFunctionLogger(Session * pxzSession, Core_String functionName, Core_Boolean enableFunction, Core_Boolean enableParameters, Core_Boolean enableExecutionTime);
// Get the CAD precision
PXZ_EXPORTED Geom_Distance CAD_getPrecision(Session * pxzSession);
// Set the CAD unity length property
PXZ_EXPORTED void CAD_setUnitLength(Session * pxzSession, Geom_Distance precision);

// ----------------------------------------------------
// Boolean Operators
// CSG Boolean operator
// ----------------------------------------------------

// perform boolean operation intersection on two bodies (A ^ B)
PXZ_EXPORTED CAD_BodyList CAD_solidIntersection(Session * pxzSession, CAD_Body A, CAD_Body B);
// perform boolean operation subtraction on two bodies (A - B)
PXZ_EXPORTED CAD_BodyList CAD_solidSubtraction(Session * pxzSession, CAD_Body A, CAD_Body B);
// perform boolean operation union on two bodies (A + B)
PXZ_EXPORTED CAD_BodyList CAD_solidUnion(Session * pxzSession, CAD_Body A, CAD_Body B);

// ----------------------------------------------------
// curves
// Curve creation functions
// ----------------------------------------------------

// Create a Bezier curve
PXZ_EXPORTED CAD_Curve CAD_createBezierCurve(Session * pxzSession, Geom_Point3List poles);
// Create a new circle
PXZ_EXPORTED CAD_Curve CAD_createCircleCurve(Session * pxzSession, Geom_Distance radius, Geom_Matrix4 matrix);
// Create a composite curve from a list of limited curves
PXZ_EXPORTED CAD_Curve CAD_createCompositeCurve(Session * pxzSession, CAD_CurveList CurveList);
// Create a cosinus curve
PXZ_EXPORTED CAD_Curve CAD_createCosinusCurve(Session * pxzSession, Geom_Distance Amplitude, Geom_Distance Offset, Geom_Distance Period, Geom_Matrix4 matrix);
// Create an ellipse curve
PXZ_EXPORTED CAD_Curve CAD_createEllipseCurve(Session * pxzSession, Geom_Distance URadius, Geom_Distance VRadius, Geom_Matrix4 matrix);
// Create an helix curve
PXZ_EXPORTED CAD_Curve CAD_createHelixCurve(Session * pxzSession, Geom_Distance radius, Geom_Distance pitch, Geom_Matrix4 matrix, Core_Boolean trigonometrixOrientation);
// Create a Hermite Curve
PXZ_EXPORTED CAD_Curve CAD_createHermiteCurve(Session * pxzSession, Geom_Point3 FirstPoint, Geom_Point3 FirstTangent, Geom_Point3 SecondPoint, Geom_Point3 SecondTangent);
// Create an hyperBola curve
PXZ_EXPORTED CAD_Curve CAD_createHyperbolaCurve(Session * pxzSession, Core_Double URadius, Core_Double VRadius, Geom_Matrix4 matrix);
// Create a Intersection Curve
PXZ_EXPORTED CAD_Curve CAD_createIntersectionCurve(Session * pxzSession, CAD_Surface firstSurface, CAD_Surface secondSurface, CAD_PolylineCurve chart, Core_Double minBounds, Core_Double maxBounds);
// Create a Line Curve
PXZ_EXPORTED CAD_Curve CAD_createLineCurve(Session * pxzSession, Geom_Point3 OriginPt, Geom_Point3 DirectionPt);
// Create a NURBS curve
PXZ_EXPORTED CAD_Curve CAD_createNURBSCurve(Session * pxzSession, Core_Int degree, Core_DoubleList knots, Geom_Point3List poles, Core_DoubleList weights);
// Create an parabola curve
PXZ_EXPORTED CAD_Curve CAD_createParabolaCurve(Session * pxzSession, Core_Double focalLength, Geom_Matrix4 matrix);
// Create a Polyline curve
PXZ_EXPORTED CAD_Curve CAD_createPolylineCurve(Session * pxzSession, Geom_Point3List points, Core_DoubleList parameters);
// Create a segment curve from two given points
PXZ_EXPORTED CAD_Curve CAD_createSegmentCurve(Session * pxzSession, Geom_Point3 firstPoint, Geom_Point3 secondPoint);
// Create a curve from a surface
PXZ_EXPORTED CAD_Curve CAD_createSurfacicCurve(Session * pxzSession, CAD_Surface surface, CAD_Curve curve2D);
// Create a curve from a surface
PXZ_EXPORTED CAD_Curve CAD_createTransformedCurve(Session * pxzSession, CAD_Curve curve, Geom_Matrix4 matrix);
// Invert a curve parametricaly
PXZ_EXPORTED CAD_Curve CAD_invertCurve(Session * pxzSession, CAD_Curve curve, Core_Double precision);

// ----------------------------------------------------
// extrusion creation
// CAD extrusion creation functions
// ----------------------------------------------------

// create a revolved extrusion
PXZ_EXPORTED CAD_Body CAD_createRevolveExtrusion(Session * pxzSession, CAD_CurveList profileCurves, Geom_Point3 center, Geom_Vector3 direction, Core_Double angle, Core_Bool area);

// ----------------------------------------------------
// material
// ----------------------------------------------------

// get the material on a face
PXZ_EXPORTED Material_Material CAD_getFaceMaterial(Session * pxzSession, CAD_Face face);
// set the material on a face
PXZ_EXPORTED void CAD_setFaceMaterial(Session * pxzSession, CAD_Face face, Material_Material material);

// ----------------------------------------------------
// model management
// CAD model management functions
// ----------------------------------------------------

// Add a body to the model
PXZ_EXPORTED void CAD_addBodyToModel(Session * pxzSession, CAD_Body body, CAD_Model model);
// Add an edge to the model
PXZ_EXPORTED void CAD_addEdgeToModel(Session * pxzSession, CAD_Edge edge, CAD_Model model);
// Add an open shell to the model
PXZ_EXPORTED void CAD_addOpenShellToModel(Session * pxzSession, CAD_OpenShell shell, CAD_Model model);
// Add a vertex to the model
PXZ_EXPORTED void CAD_addVertexToModel(Session * pxzSession, CAD_Vertex vtx, CAD_Model model);
// Build faces from a surface and a set of loop
typedef struct {
   CAD_FaceList faces;
   CAD_SplittedEdgeList splittingInfo;
} CAD_buildFacesReturn;
PXZ_EXPORTED CAD_buildFacesReturn CAD_buildFaces(Session * pxzSession, CAD_Surface surface, CAD_LoopList loopList);
// Create a new model
PXZ_EXPORTED CAD_Model CAD_createModel(Session * pxzSession, Geom_Distance precision);
// Create a new BrepSession on current thread
PXZ_EXPORTED void CAD_endThreadBrepSession(Session * pxzSession);
// Get all the face of a model recursively
PXZ_EXPORTED CAD_FaceList CAD_getAllModelFaces(Session * pxzSession, CAD_Model model);
// Get the list of bodies contained in a model
PXZ_EXPORTED CAD_BodyList CAD_getModelBodies(Session * pxzSession, CAD_Model model);
// Get boundary edges of a model grouped by cycles
PXZ_EXPORTED CAD_EdgeListList CAD_getModelBoundaries(Session * pxzSession, CAD_Model model);
// Get the list of free edges contained in a model
PXZ_EXPORTED CAD_EdgeList CAD_getModelEdges(Session * pxzSession, CAD_Model model);
// Get the list of open shells contained in a model
PXZ_EXPORTED CAD_OpenShellList CAD_getModelOpenShells(Session * pxzSession, CAD_Model model);
// Get the list of free vertices contained in a model
PXZ_EXPORTED CAD_VertexList CAD_getModelVertices(Session * pxzSession, CAD_Model model);
// Returns the entities referencing a given CAD entity
PXZ_EXPORTED Core_EntityList CAD_getReferencers(Session * pxzSession, CAD_CADEntity entity);
// Create a new BrepSession on current thread
PXZ_EXPORTED void CAD_startThreadBrepSession(Session * pxzSession, Geom_Distance precision);

// ----------------------------------------------------
// primitives
// CAD primitives creation functions
// ----------------------------------------------------

// Creates a BRep Cone whose axis is the Z axis centered on O
PXZ_EXPORTED CAD_Body CAD_createBRepCone(Session * pxzSession, Core_Double radius, Core_Double height, Geom_Matrix4 matrix);
// Creates a BRep Cube
PXZ_EXPORTED CAD_Body CAD_createBRepCube(Session * pxzSession, Core_Double size, Geom_Matrix4 matrix);
// Creates a BRep Cylinder aligned on the Z axis centered on O
PXZ_EXPORTED CAD_Body CAD_createBRepCylinder(Session * pxzSession, Core_Double radius, Core_Double length, Geom_Matrix4 matrix);
// Creates a BRep Plane whose normal is the Z axis centered on O
PXZ_EXPORTED CAD_Body CAD_createBRepPlane(Session * pxzSession, Core_Double length, Core_Double width, Geom_Matrix4 matrix);
// Creates a BRep Sphere centered on O and whose singularities are on the Z axis
PXZ_EXPORTED CAD_Body CAD_createBRepSphere(Session * pxzSession, Core_Double radius, Geom_Matrix4 matrix);
// Creates a BRep Torus whose axis is the Z axis centered on O
PXZ_EXPORTED CAD_Body CAD_createBRepTorus(Session * pxzSession, Core_Double majorRadius, Core_Double minorRadius, Geom_Matrix4 matrix);
// Creates a BRep Lego brick
PXZ_EXPORTED CAD_Body CAD_createLegoBrick(Session * pxzSession, CAD_LegoBrickDefinition brickDefinition);

// ----------------------------------------------------
// structure access
// CAD structure access functions
// ----------------------------------------------------

// evaluate curvature on a curve
PXZ_EXPORTED Core_Double CAD_evalCurvatureOnCurve(Session * pxzSession, CAD_Curve curve, Core_Double parameter);
// evaluate main curvatures on a surface
PXZ_EXPORTED Geom_Curvatures CAD_evalCurvatureOnSurface(Session * pxzSession, CAD_Surface surface, Geom_Point2 parameter);
// evaluate a point and derivatives on a curve
typedef struct {
   Geom_Point3 d0;
   Geom_Point3 du;
   Geom_Point3 d2u;
} CAD_evalOnCurveReturn;
PXZ_EXPORTED CAD_evalOnCurveReturn CAD_evalOnCurve(Session * pxzSession, CAD_Curve curve, Core_Double parameter, Core_Int derivation);
// evaluate a point and derivatives on a surface
typedef struct {
   Geom_Point3 d0;
   Geom_Point3 du;
   Geom_Point3 dv;
   Geom_Point3 d2u;
   Geom_Point3 d2v;
   Geom_Point3 duv;
} CAD_evalOnSurfaceReturn;
PXZ_EXPORTED CAD_evalOnSurfaceReturn CAD_evalOnSurface(Session * pxzSession, CAD_Surface surface, Geom_Point2 parameter, Core_Int derivation);
// get all closedShells contain in the body
PXZ_EXPORTED CAD_ClosedShellList CAD_getBodyClosedShells(Session * pxzSession, CAD_Body body);
// get all parameters contained in the circleCurve
typedef struct {
   Core_Double radius;
   Geom_Matrix4 matrix;
} CAD_getCircleCurveDefinitionReturn;
PXZ_EXPORTED CAD_getCircleCurveDefinitionReturn CAD_getCircleCurveDefinition(Session * pxzSession, CAD_CircleCurve circleCurve);
// get all orienteFaces contain in the closedShell
PXZ_EXPORTED CAD_OrientedFaceList CAD_getClosedShellOrientedFaces(Session * pxzSession, CAD_ClosedShell closedShell);
// get all parameters contained in the coEdge
typedef struct {
   CAD_Edge edge;
   Geom_Orientation edgeOrientation;
   CAD_Loop loop;
   CAD_Surface surface;
   CAD_Curve parametricCurve;
} CAD_getCoEdgeDefinitionReturn;
PXZ_EXPORTED CAD_getCoEdgeDefinitionReturn CAD_getCoEdgeDefinition(Session * pxzSession, CAD_CoEdge coEdge);
// get all parameters contained in the compositeCurve
typedef struct {
   CAD_CurveList curves;
   Core_DoubleList parameters;
} CAD_getCompositeCurveDefinitionReturn;
PXZ_EXPORTED CAD_getCompositeCurveDefinitionReturn CAD_getCompositeCurveDefinition(Session * pxzSession, CAD_CompositeCurve compositeCurve);
// get all parameters contained in the coneSurface
typedef struct {
   Core_Double radius;
   Core_Double semiAngle;
   Geom_Matrix4 matrix;
} CAD_getConeSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getConeSurfaceDefinitionReturn CAD_getConeSurfaceDefinition(Session * pxzSession, CAD_ConeSurface coneSurface);
// get all parameters contained in the curveExtrusionSurface
typedef struct {
   CAD_Curve generatrixCurve;
   CAD_Curve directrixCruve;
   CAD_Surface surfaceReference;
} CAD_getCurveExtrusionSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getCurveExtrusionSurfaceDefinitionReturn CAD_getCurveExtrusionSurfaceDefinition(Session * pxzSession, CAD_CurveExtrusionSurface curveExtrusionSurface);
// returns the length of the curve
PXZ_EXPORTED Core_Double CAD_getCurveLength(Session * pxzSession, CAD_Curve curve);
// get the parametric space limits of a curve
PXZ_EXPORTED CAD_Bounds1D CAD_getCurveLimits(Session * pxzSession, CAD_Curve curve);
// get all parameters contained in the cylinderSurface
typedef struct {
   Core_Double radius;
   Geom_Matrix4 matrix;
} CAD_getCylinderSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getCylinderSurfaceDefinitionReturn CAD_getCylinderSurfaceDefinition(Session * pxzSession, CAD_CylinderSurface cylinderSurface);
// get all parameters contained in the edge
typedef struct {
   CAD_Vertex vertex1;
   CAD_Vertex vertex2;
   CAD_Curve curve;
   CAD_Bounds1D bounds;
} CAD_getEdgeDefinitionReturn;
PXZ_EXPORTED CAD_getEdgeDefinitionReturn CAD_getEdgeDefinition(Session * pxzSession, CAD_Edge edge);
// returns the length of the edge
PXZ_EXPORTED Core_Double CAD_getEdgeLength(Session * pxzSession, CAD_Edge edge);
// get all parameters contained in the ellipseCurve
typedef struct {
   Core_Double radius1;
   Core_Double radius2;
   Geom_Matrix4 matrix;
} CAD_getEllipseCurveDefinitionReturn;
PXZ_EXPORTED CAD_getEllipseCurveDefinitionReturn CAD_getEllipseCurveDefinition(Session * pxzSession, CAD_EllipseCurve ellipseCurve);
// get all parameters contained in the ellipticConeSurface
typedef struct {
   Core_Double radius1;
   Core_Double radius2;
   Core_Double semiAngle;
   Geom_Matrix4 matrix;
} CAD_getEllipticConeSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getEllipticConeSurfaceDefinitionReturn CAD_getEllipticConeSurfaceDefinition(Session * pxzSession, CAD_EllipticConeSurface ellipticConeSurface);
// get all parameters contain in the face
typedef struct {
   CAD_Surface surface;
   CAD_LoopList loops;
   Geom_Orientation orientation;
   CAD_Bounds2D limits;
} CAD_getFaceDefinitionReturn;
PXZ_EXPORTED CAD_getFaceDefinitionReturn CAD_getFaceDefinition(Session * pxzSession, CAD_Face face);
// get parametric definition of each face loop
PXZ_EXPORTED Geom_Point2ListList CAD_getFaceParametricBoundaries(Session * pxzSession, CAD_Face face);
// get all parameters contained in the helixCurve
typedef struct {
   Core_Double radius;
   Geom_Matrix4 matrix;
   Core_Boolean trigonometricOrientation;
} CAD_getHelixCurveDefinitionReturn;
PXZ_EXPORTED CAD_getHelixCurveDefinitionReturn CAD_getHelixCurveDefinition(Session * pxzSession, CAD_HelixCurve helixCurve);
// get all parameters contained in the hermiteCurve
typedef struct {
   Geom_Point3 firstPoint;
   Geom_Point3 secondPoint;
   Geom_Point3 firstTangent;
   Geom_Point3 secondTangent;
} CAD_getHermiteCurveDefinitionReturn;
PXZ_EXPORTED CAD_getHermiteCurveDefinitionReturn CAD_getHermiteCurveDefinition(Session * pxzSession, CAD_HermiteCurve hermiteCurve);
// get all parameters contained in the hyperbolaCurve
typedef struct {
   Core_Double radius1;
   Core_Double radius2;
   Geom_Matrix4 matrix;
} CAD_getHyperbolaCurveDefinitionReturn;
PXZ_EXPORTED CAD_getHyperbolaCurveDefinitionReturn CAD_getHyperbolaCurveDefinition(Session * pxzSession, CAD_HyperbolaCurve hyperbolaCurve);
// get all parameters contained in the intersectionCurve
typedef struct {
   CAD_Surface surface1;
   CAD_Surface surface2;
   CAD_PolylineCurve chart;
   CAD_Bounds1D bounds;
} CAD_getIntersectionCurveDefinitionReturn;
PXZ_EXPORTED CAD_getIntersectionCurveDefinitionReturn CAD_getIntersectionCurveDefinition(Session * pxzSession, CAD_IntersectionCurve intersectionCurve);
// get all parameters contain in the lineCurve
typedef struct {
   Geom_Point3 origin;
   Geom_Point3 direction;
} CAD_getLineCurveDefinitionReturn;
PXZ_EXPORTED CAD_getLineCurveDefinitionReturn CAD_getLineCurveDefinition(Session * pxzSession, CAD_LineCurve lineCurve);
// get all coEdges contain in the loop
PXZ_EXPORTED CAD_CoEdgeList CAD_getLoopCoEdges(Session * pxzSession, CAD_Loop loop);
// get all parameters contained in the nurbsCurve
typedef struct {
   Core_Int degree;
   Core_DoubleList knots;
   Geom_Point3List poles;
   Core_DoubleList weights;
} CAD_getNURBSCurveDefinitionReturn;
PXZ_EXPORTED CAD_getNURBSCurveDefinitionReturn CAD_getNURBSCurveDefinition(Session * pxzSession, CAD_NURBSCurve nurbsCurve);
// get all parameters contained in the nurbsSurface
typedef struct {
   Core_Int degreeU;
   Core_Int degreeV;
   Core_DoubleList knotsU;
   Core_DoubleList knotsV;
   Geom_Point3ListList poles;
   Core_DoubleListList weights;
} CAD_getNURBSSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getNURBSSurfaceDefinitionReturn CAD_getNURBSSurfaceDefinition(Session * pxzSession, CAD_NURBSSurface nurbsSurface);
// get all parameters contained in the offsetCurve
typedef struct {
   CAD_Curve curve;
   Geom_Point3 direction;
   Core_Double distance;
   CAD_Surface surfaceReference;
} CAD_getOffsetCurveDefinitionReturn;
PXZ_EXPORTED CAD_getOffsetCurveDefinitionReturn CAD_getOffsetCurveDefinition(Session * pxzSession, CAD_OffsetCurve offsetCurve);
// get all parameters contained in the offsetSurface
typedef struct {
   CAD_Surface baseSurface;
   Core_Double distance;
} CAD_getOffsetSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getOffsetSurfaceDefinitionReturn CAD_getOffsetSurfaceDefinition(Session * pxzSession, CAD_OffsetSurface offsetSurface);
// get all orienteFaces contain in the openShell
PXZ_EXPORTED CAD_OrientedFaceList CAD_getOpenShellOrientedFaces(Session * pxzSession, CAD_OpenShell openShell);
// get all parameters contained in the parabolaCurve
typedef struct {
   Core_Double focalLength;
   Geom_Matrix4 matrix;
} CAD_getParabolaCurveDefinitionReturn;
PXZ_EXPORTED CAD_getParabolaCurveDefinitionReturn CAD_getParabolaCurveDefinition(Session * pxzSession, CAD_ParabolaCurve parabolaCurve);
// returns the parametric precision of a surface from the input precision
PXZ_EXPORTED Core_Double CAD_getParametricPrecisionOnSurface(Session * pxzSession, CAD_Surface surface, Core_Double precision);
// get all parameters contained in the planeSurface
PXZ_EXPORTED Geom_Matrix4 CAD_getPlaneSurfaceDefinition(Session * pxzSession, CAD_PlaneSurface planeSurface);
// get all parameters contained in the polylinCurve
typedef struct {
   Geom_Point3List points;
   Core_DoubleList parameters;
} CAD_getPolylineCurveDefinitionReturn;
PXZ_EXPORTED CAD_getPolylineCurveDefinitionReturn CAD_getPolylineCurveDefinition(Session * pxzSession, CAD_PolylineCurve polylineCurve);
// get all parameters contained in the revolutionSurface
typedef struct {
   CAD_Curve generatricCurve;
   Geom_Point3 axisOrigin;
   Geom_Point3 axisDirection;
   Core_Double startAngle;
   Core_Double endAngle;
} CAD_getRevolutionSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getRevolutionSurfaceDefinitionReturn CAD_getRevolutionSurfaceDefinition(Session * pxzSession, CAD_RevolutionSurface revolutionSurface);
// get all parameters contained in the ruledSurface
typedef struct {
   CAD_Curve firstCurve;
   CAD_Curve secondCurve;
} CAD_getRuledSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getRuledSurfaceDefinitionReturn CAD_getRuledSurfaceDefinition(Session * pxzSession, CAD_RuledSurface ruledSurface);
// get all parameters contained in the segmentCurve
typedef struct {
   Geom_Point3 startPoint;
   Geom_Point3 endPoint;
} CAD_getSegmentCurveDefinitionReturn;
PXZ_EXPORTED CAD_getSegmentCurveDefinitionReturn CAD_getSegmentCurveDefinition(Session * pxzSession, CAD_SegmentCurve segmentCurve);
// get all parameters contained in the sphereSurface
typedef struct {
   Core_Double radius;
   Geom_Matrix4 matrix;
} CAD_getSphereSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getSphereSurfaceDefinitionReturn CAD_getSphereSurfaceDefinition(Session * pxzSession, CAD_SphereSurface sphereSurface);
// get the parametric space limits of a surface
PXZ_EXPORTED CAD_Bounds2D CAD_getSurfaceLimits(Session * pxzSession, CAD_Surface surface);
// get all parameters contained in the surfacicCurve
typedef struct {
   CAD_Surface surface;
   CAD_Curve curve2D;
} CAD_getSurfacicCurveDefinitionReturn;
PXZ_EXPORTED CAD_getSurfacicCurveDefinitionReturn CAD_getSurfacicCurveDefinition(Session * pxzSession, CAD_SurfacicCurve surfacicCurve);
// get all parameters contained in the TabulatedCylinderSurface
typedef struct {
   CAD_Curve directrixCurve;
   Geom_Point3 generatrixLine;
   CAD_Bounds1D range;
} CAD_getTabulatedCylinderSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getTabulatedCylinderSurfaceDefinitionReturn CAD_getTabulatedCylinderSurfaceDefinition(Session * pxzSession, CAD_TabulatedCylinderSurface tabulatedCylinderSurface);
// get all parameters contained in the torusSurface
typedef struct {
   Core_Double majorRadius;
   Core_Double minorRadius;
   Geom_Matrix4 matrix;
   Core_Int type;
} CAD_getTorusSurfaceDefinitionReturn;
PXZ_EXPORTED CAD_getTorusSurfaceDefinitionReturn CAD_getTorusSurfaceDefinition(Session * pxzSession, CAD_TorusSurface torusSurface);
// get all parameters contained in the transformedCurve
typedef struct {
   CAD_Curve curve;
   Geom_Matrix4 matrix;
} CAD_getTransformedCurveDefinitionReturn;
PXZ_EXPORTED CAD_getTransformedCurveDefinitionReturn CAD_getTransformedCurveDefinition(Session * pxzSession, CAD_TransformedCurve transformedCurve);
// get the position of the vertex
PXZ_EXPORTED Geom_Point3 CAD_getVertexPosition(Session * pxzSession, CAD_Vertex vertex);
// invert a point to a curve
PXZ_EXPORTED Core_Double CAD_invertOnCurve(Session * pxzSession, CAD_Curve curve, Geom_Point3 point, Core_Double precision);
// invert a point to a surface
PXZ_EXPORTED Geom_Point2 CAD_invertOnSurface(Session * pxzSession, CAD_Surface surface, Geom_Point3 point, Core_Double precision);
// if the curve is closed, return true, return false otherwise
PXZ_EXPORTED Core_Boolean CAD_isCurveClosed(Session * pxzSession, CAD_Curve curve);
// if the curve is finite return true, return false otherwise
PXZ_EXPORTED Core_Boolean CAD_isCurveFinite(Session * pxzSession, CAD_Curve curve);
// if the curve is periodic return true, return false otherwise
typedef struct {
   Core_Boolean periodic;
   Core_Double period;
} CAD_isCurvePeriodicReturn;
PXZ_EXPORTED CAD_isCurvePeriodicReturn CAD_isCurvePeriodic(Session * pxzSession, CAD_Curve curve);
// return if the surface is closed on U or on V
typedef struct {
   Core_Boolean closedU;
   Core_Boolean closedV;
} CAD_isSurfaceClosedReturn;
PXZ_EXPORTED CAD_isSurfaceClosedReturn CAD_isSurfaceClosed(Session * pxzSession, CAD_Surface surface);
// return if the surface is periodic on U or on V
typedef struct {
   Core_Boolean periodicU;
   Core_Boolean periodicV;
   Core_Double periodU;
   Core_Double periodV;
} CAD_isSurfacePeriodicReturn;
PXZ_EXPORTED CAD_isSurfacePeriodicReturn CAD_isSurfacePeriodic(Session * pxzSession, CAD_Surface surface);
PXZ_EXPORTED Core_Boolean CAD_needTorusShapeCheck(Session * pxzSession, CAD_Surface surface, Geom_Point3List points);
// project a point to a curve
PXZ_EXPORTED Core_Double CAD_projectOnCurve(Session * pxzSession, CAD_Curve curve, Geom_Point3 point, Core_Double precision);
// project a point to a surface
PXZ_EXPORTED Geom_Point2 CAD_projectOnSurface(Session * pxzSession, CAD_Surface surface, Geom_Point3 point, Core_Double precision);
// Set the curve 2D value of a coEdge
PXZ_EXPORTED void CAD_setCoEdgeCurve2D(Session * pxzSession, CAD_CoEdge coEdge, CAD_Curve curve2D);
// Set the surface value of a coEdge
PXZ_EXPORTED void CAD_setCoEdgeSurface(Session * pxzSession, CAD_CoEdge coEdge, CAD_Surface surface);
// set the parametric space limits of a curve
PXZ_EXPORTED void CAD_setCurveLimits(Session * pxzSession, CAD_Curve curve, CAD_Bounds1D limits);
// Define an edge's edge style
PXZ_EXPORTED void CAD_setEdgeStyle(Session * pxzSession, CAD_Edge edge, CAD_EdgeStyle style);

// ----------------------------------------------------
// structure creation
// CAD structure creation functions
// ----------------------------------------------------

// Create a body from a surface
PXZ_EXPORTED CAD_Body CAD_createBody(Session * pxzSession, CAD_ClosedShell outerShell, CAD_ClosedShellList innerShells);
// Create a closedShell from a set of faces of a set of orientations
PXZ_EXPORTED CAD_ClosedShell CAD_createClosedShell(Session * pxzSession, CAD_FaceList faces, Geom_OrientationList orientations);
// Create an coEdge with a edge and an orientation
PXZ_EXPORTED CAD_CoEdge CAD_createCoEdge(Session * pxzSession, CAD_Edge edge, Geom_Orientation orientation, CAD_Surface surface, CAD_Curve curve2D);
// Create an edge with a curve an extremity vertices
PXZ_EXPORTED CAD_Edge CAD_createEdge(Session * pxzSession, CAD_Curve curve, CAD_Vertex startVertex, CAD_Vertex endVertex);
// Create an edge from a limited curve
PXZ_EXPORTED CAD_Edge CAD_createEdgeFromCurve(Session * pxzSession, CAD_Curve curve);
// Create a face from a surface
PXZ_EXPORTED CAD_Face CAD_createFace(Session * pxzSession, CAD_Surface surface, CAD_LoopList loopList, Core_Boolean useSurfaceOrientation);
// Create a loop from a set of edges of a set of orientations
PXZ_EXPORTED CAD_Loop CAD_createLoop(Session * pxzSession, CAD_CoEdgeList coEdges, Core_Boolean check);
// Create a openShell from a set of faces of a set of orientations and set of loops
PXZ_EXPORTED CAD_OpenShell CAD_createOpenShell(Session * pxzSession, CAD_FaceList faces, Geom_OrientationList orientations);
// Create a vertex from a position
PXZ_EXPORTED CAD_Vertex CAD_createVertex(Session * pxzSession, Geom_Point3 position);
// Invert a coedge
PXZ_EXPORTED void CAD_invertCoEdge(Session * pxzSession, CAD_CoEdge coedge);
// Invert faces
PXZ_EXPORTED void CAD_invertFaces(Session * pxzSession, CAD_FaceList faces);
// Invert a loop
PXZ_EXPORTED void CAD_invertLoop(Session * pxzSession, CAD_Loop loop);
// return if the surface is finite
PXZ_EXPORTED Core_Boolean CAD_isSurfaceFinite(Session * pxzSession, CAD_Surface surface);

// ----------------------------------------------------
// surfaces
// Surface creation functions
// ----------------------------------------------------

PXZ_EXPORTED void CAD_addPrecisionArea(Session * pxzSession, CAD_Surface surface, Geom_AABR aabr);
// Create a new bezier surface
PXZ_EXPORTED CAD_Surface CAD_createBezierSurface(Session * pxzSession, Core_Int degreeU, Core_Int degreeV, Geom_Point3List poles);
// Create a new cone surface
PXZ_EXPORTED CAD_Surface CAD_createConeSurface(Session * pxzSession, Geom_Distance radius, Geom_Angle semiAngle, Geom_Matrix4 matrix);
// Create a new curveExtrusion surface
PXZ_EXPORTED CAD_Surface CAD_createCurveExtrusionSurface(Session * pxzSession, CAD_Curve generatrixCurve, CAD_Curve directrixCurve, CAD_Surface refSurface);
// Create a new cylinder surface
PXZ_EXPORTED CAD_Surface CAD_createCylinderSurface(Session * pxzSession, Geom_Distance radius, Geom_Matrix4 matrix);
// Create a new elliptic cone surface
PXZ_EXPORTED CAD_Surface CAD_createEllipticConeSurface(Session * pxzSession, Geom_Distance radius1, Geom_Distance radius2, Geom_Angle semiAngle, Geom_Matrix4 matrix);
// Create a new NURBS surface
PXZ_EXPORTED CAD_Surface CAD_createNURBSSurface(Session * pxzSession, Core_Int degreeU, Core_Int degreeV, Core_DoubleList knotsU, Core_DoubleList knotsV, Geom_Point3List poles, Core_DoubleList weights);
// Create a new offset surface
PXZ_EXPORTED CAD_Surface CAD_createOffsetSurface(Session * pxzSession, CAD_Surface baseSurface, Core_Double distance);
// Create a new plane surface
PXZ_EXPORTED CAD_Surface CAD_createPlaneSurface(Session * pxzSession, Geom_Matrix4 matrix);
// Create a new revolution surface
PXZ_EXPORTED CAD_Surface CAD_createRevolutionSurface(Session * pxzSession, CAD_Curve generatrixCurve, Geom_Point3 axisOrigin, Geom_Vector3 axisDirection, Geom_Angle startAngle, Geom_Angle endAngle);
// Create a new ruled surface
PXZ_EXPORTED CAD_Surface CAD_createRuledSurface(Session * pxzSession, CAD_Curve firstCurve, CAD_Curve secondCurve);
// Create a new sphere surface
PXZ_EXPORTED CAD_Surface CAD_createSphereSurface(Session * pxzSession, Geom_Distance radius, Geom_Matrix4 matrix);
// Create a new tabulated cylinder surface
PXZ_EXPORTED CAD_Surface CAD_createTabulatedCylinderSurface(Session * pxzSession, CAD_Curve directrixCurve, Geom_Point3 GeneratixLine, Geom_Distance minRange, Geom_Distance maxRange);
// Create a new torus surface
PXZ_EXPORTED CAD_Surface CAD_createTorusSurface(Session * pxzSession, Geom_Distance radiusMax, Geom_Distance radiusMin, Geom_Matrix4 matrix);
// tells if it needs a working area on the surface
PXZ_EXPORTED Core_Boolean CAD_needPrecisionArea(Session * pxzSession, CAD_Surface surface);



#endif
