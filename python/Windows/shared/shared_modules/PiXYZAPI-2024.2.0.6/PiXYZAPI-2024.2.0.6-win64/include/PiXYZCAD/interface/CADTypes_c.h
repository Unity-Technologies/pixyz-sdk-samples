// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_CAD_INTERFACE_CADTYPES_C_H_
#define _PXZ_CAD_INTERFACE_CADTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZGeom/interface/GeomTypes_c.h>
#include <PiXYZMaterial/interface/MaterialTypes_c.h>


typedef Geom_GeomEntity CAD_CADEntity;

typedef CAD_CADEntity CAD_Shape;

typedef CAD_Shape CAD_Body;

typedef struct {
   size_t size;
   CAD_Body * list;
} CAD_BodyList;

PXZ_EXPORTED void CAD_BodyList_init(CAD_BodyList * list, size_t size = 0);
PXZ_EXPORTED void CAD_BodyList_free(CAD_BodyList * list);
typedef struct {
   Core_Double min;
   Core_Double max;
} CAD_Bounds1D;

PXZ_EXPORTED void CAD_Bounds1D_init(CAD_Bounds1D * str);
PXZ_EXPORTED void CAD_Bounds1D_free(CAD_Bounds1D * str);
typedef struct {
   CAD_Bounds1D u;
   CAD_Bounds1D v;
} CAD_Bounds2D;

PXZ_EXPORTED void CAD_Bounds2D_init(CAD_Bounds2D * str);
PXZ_EXPORTED void CAD_Bounds2D_free(CAD_Bounds2D * str);
typedef CAD_CADEntity CAD_Curve;

typedef CAD_Curve CAD_CircleCurve;

typedef CAD_CADEntity CAD_ClosedShell;

typedef struct {
   size_t size;
   CAD_ClosedShell * list;
} CAD_ClosedShellList;

PXZ_EXPORTED void CAD_ClosedShellList_init(CAD_ClosedShellList * list, size_t size = 0);
PXZ_EXPORTED void CAD_ClosedShellList_free(CAD_ClosedShellList * list);
typedef CAD_CADEntity CAD_CoEdge;

typedef struct {
   size_t size;
   CAD_CoEdge * list;
} CAD_CoEdgeList;

PXZ_EXPORTED void CAD_CoEdgeList_init(CAD_CoEdgeList * list, size_t size = 0);
PXZ_EXPORTED void CAD_CoEdgeList_free(CAD_CoEdgeList * list);
typedef CAD_Curve CAD_CompositeCurve;

typedef CAD_CADEntity CAD_Surface;

typedef CAD_Surface CAD_ConeSurface;

typedef CAD_Surface CAD_CurveExtrusionSurface;

typedef struct {
   size_t size;
   CAD_Curve * list;
} CAD_CurveList;

PXZ_EXPORTED void CAD_CurveList_init(CAD_CurveList * list, size_t size = 0);
PXZ_EXPORTED void CAD_CurveList_free(CAD_CurveList * list);
typedef CAD_Surface CAD_CylinderSurface;

typedef CAD_Shape CAD_Edge;

typedef struct {
   size_t size;
   CAD_Edge * list;
} CAD_EdgeList;

PXZ_EXPORTED void CAD_EdgeList_init(CAD_EdgeList * list, size_t size = 0);
PXZ_EXPORTED void CAD_EdgeList_free(CAD_EdgeList * list);
typedef struct {
   size_t size;
   CAD_EdgeList * list;
} CAD_EdgeListList;

PXZ_EXPORTED void CAD_EdgeListList_init(CAD_EdgeListList * list, size_t size = 0);
PXZ_EXPORTED void CAD_EdgeListList_free(CAD_EdgeListList * list);
typedef struct {
   Core_ColorAlpha color;
   Core_Double width;
   Core_Short pattern;
} CAD_EdgeStyle;

PXZ_EXPORTED void CAD_EdgeStyle_init(CAD_EdgeStyle * str);
PXZ_EXPORTED void CAD_EdgeStyle_free(CAD_EdgeStyle * str);
typedef CAD_Curve CAD_EllipseCurve;

typedef CAD_Surface CAD_EllipticConeSurface;

typedef CAD_Shape CAD_Face;

typedef struct {
   size_t size;
   CAD_Face * list;
} CAD_FaceList;

PXZ_EXPORTED void CAD_FaceList_init(CAD_FaceList * list, size_t size = 0);
PXZ_EXPORTED void CAD_FaceList_free(CAD_FaceList * list);
typedef CAD_Curve CAD_HelixCurve;

typedef CAD_Curve CAD_HermiteCurve;

typedef CAD_Curve CAD_HyperbolaCurve;

typedef CAD_Curve CAD_IntersectionCurve;

typedef enum {
 CAD_LegoType_Rectangle = 0,
 CAD_LegoType_CornerLeft = 1,
 CAD_LegoType_CornerRight = 2,
} CAD_LegoType;

typedef struct {
   CAD_LegoType legoType;
   Core_Int length;
   Core_Int width;
   Core_Boolean fullHeight;
} CAD_LegoBrickDefinition;

PXZ_EXPORTED void CAD_LegoBrickDefinition_init(CAD_LegoBrickDefinition * str);
PXZ_EXPORTED void CAD_LegoBrickDefinition_free(CAD_LegoBrickDefinition * str);
typedef struct {
   size_t size;
   CAD_LegoBrickDefinition * list;
} CAD_LegoBrickDefinitionList;

PXZ_EXPORTED void CAD_LegoBrickDefinitionList_init(CAD_LegoBrickDefinitionList * list, size_t size = 0);
PXZ_EXPORTED void CAD_LegoBrickDefinitionList_free(CAD_LegoBrickDefinitionList * list);
typedef CAD_Curve CAD_LineCurve;

typedef CAD_CADEntity CAD_Loop;

typedef struct {
   size_t size;
   CAD_Loop * list;
} CAD_LoopList;

PXZ_EXPORTED void CAD_LoopList_init(CAD_LoopList * list, size_t size = 0);
PXZ_EXPORTED void CAD_LoopList_free(CAD_LoopList * list);
typedef CAD_CADEntity CAD_Model;

typedef struct {
   size_t size;
   CAD_Model * list;
} CAD_ModelList;

PXZ_EXPORTED void CAD_ModelList_init(CAD_ModelList * list, size_t size = 0);
PXZ_EXPORTED void CAD_ModelList_free(CAD_ModelList * list);
typedef CAD_Curve CAD_NURBSCurve;

typedef CAD_Surface CAD_NURBSSurface;

typedef CAD_Curve CAD_OffsetCurve;

typedef CAD_Surface CAD_OffsetSurface;

typedef CAD_Shape CAD_OpenShell;

typedef struct {
   size_t size;
   CAD_OpenShell * list;
} CAD_OpenShellList;

PXZ_EXPORTED void CAD_OpenShellList_init(CAD_OpenShellList * list, size_t size = 0);
PXZ_EXPORTED void CAD_OpenShellList_free(CAD_OpenShellList * list);
typedef struct {
   CAD_Edge edge;
   Geom_Orientation orientation;
} CAD_OrientedEdge;

PXZ_EXPORTED void CAD_OrientedEdge_init(CAD_OrientedEdge * str);
PXZ_EXPORTED void CAD_OrientedEdge_free(CAD_OrientedEdge * str);
typedef struct {
   size_t size;
   CAD_OrientedEdge * list;
} CAD_OrientedEdgeList;

PXZ_EXPORTED void CAD_OrientedEdgeList_init(CAD_OrientedEdgeList * list, size_t size = 0);
PXZ_EXPORTED void CAD_OrientedEdgeList_free(CAD_OrientedEdgeList * list);
typedef struct {
   CAD_Face face;
   Geom_Orientation orientation;
} CAD_OrientedFace;

PXZ_EXPORTED void CAD_OrientedFace_init(CAD_OrientedFace * str);
PXZ_EXPORTED void CAD_OrientedFace_free(CAD_OrientedFace * str);
typedef struct {
   size_t size;
   CAD_OrientedFace * list;
} CAD_OrientedFaceList;

PXZ_EXPORTED void CAD_OrientedFaceList_init(CAD_OrientedFaceList * list, size_t size = 0);
PXZ_EXPORTED void CAD_OrientedFaceList_free(CAD_OrientedFaceList * list);
typedef CAD_Curve CAD_ParabolaCurve;

typedef CAD_Surface CAD_PlaneSurface;

typedef CAD_Curve CAD_PolylineCurve;

typedef CAD_Surface CAD_RevolutionSurface;

typedef CAD_Surface CAD_RuledSurface;

typedef CAD_Curve CAD_SegmentCurve;

typedef CAD_Surface CAD_SphereSurface;

typedef struct {
   CAD_Edge oldEdge;
   CAD_EdgeList newEdges;
} CAD_SplittedEdge;

PXZ_EXPORTED void CAD_SplittedEdge_init(CAD_SplittedEdge * str);
PXZ_EXPORTED void CAD_SplittedEdge_free(CAD_SplittedEdge * str);
typedef struct {
   size_t size;
   CAD_SplittedEdge * list;
} CAD_SplittedEdgeList;

PXZ_EXPORTED void CAD_SplittedEdgeList_init(CAD_SplittedEdgeList * list, size_t size = 0);
PXZ_EXPORTED void CAD_SplittedEdgeList_free(CAD_SplittedEdgeList * list);
typedef CAD_Curve CAD_SurfacicCurve;

typedef CAD_Surface CAD_TabulatedCylinderSurface;

typedef CAD_Surface CAD_TorusSurface;

typedef enum {
 CAD_TorusType_Donut = 0,
 CAD_TorusType_Vortex = 1,
 CAD_TorusType_Apple = 2,
 CAD_TorusType_Lemon = 3,
} CAD_TorusType;

typedef CAD_Curve CAD_TransformedCurve;

typedef CAD_Shape CAD_Vertex;

typedef struct {
   size_t size;
   CAD_Vertex * list;
} CAD_VertexList;

PXZ_EXPORTED void CAD_VertexList_init(CAD_VertexList * list, size_t size = 0);
PXZ_EXPORTED void CAD_VertexList_free(CAD_VertexList * list);


#endif
