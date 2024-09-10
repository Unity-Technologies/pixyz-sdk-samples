// !!! This is a generated file, do not edit !!!
#ifndef _PXZ_ALGO_INTERFACE_ALGOTYPES_C_H_
#define _PXZ_ALGO_INTERFACE_ALGOTYPES_C_H_

#include <string.h>
#include <PiXYZCore/interface/InterfaceBase_c.h>
#include <PiXYZCore/interface/CoreTypes_c.h>
#include <PiXYZGeom/interface/GeomTypes_c.h>
#include <PiXYZMaterial/interface/MaterialTypes_c.h>
#include <PiXYZPolygonal/interface/PolygonalTypes_c.h>
#include <PiXYZScene/interface/SceneTypes_c.h>


typedef enum {
 Algo_AlignmentMode_Auto = 0,
 Algo_AlignmentMode_Portrait = 1,
 Algo_AlignmentMode_Landscape = 2,
} Algo_AlignmentMode;

typedef enum {
 Algo_AttributType_Patches = 4020,
 Algo_AttributType_PatchMaterials = 4021,
 Algo_AttributType_PatchBoundaries = 4022,
 Algo_AttributType_UVs = 4035,
 Algo_AttributType_Normals = 4036,
 Algo_AttributType_Tangents = 4037,
 Algo_AttributType_Binormals = 4038,
} Algo_AttributType;

typedef enum {
 Algo_MapType_Diffuse = 0,
 Algo_MapType_Normal = 1,
 Algo_MapType_Opacity = 2,
 Algo_MapType_Roughness = 3,
 Algo_MapType_Specular = 4,
 Algo_MapType_Metallic = 5,
 Algo_MapType_AO = 6,
 Algo_MapType_Emissive = 7,
 Algo_MapType_PartId = 8,
 Algo_MapType_MaterialId = 9,
 Algo_MapType_ComputeAO = 10,
 Algo_MapType_Bent = 11,
 Algo_MapType_UV = 12,
 Algo_MapType_Displacement = 13,
 Algo_MapType_LocalPosition = 14,
 Algo_MapType_GlobalPosition = 15,
 Algo_MapType_Depth = 16,
 Algo_MapType_OccurrenceProperty = 17,
 Algo_MapType_Feature = 18,
 Algo_MapType_VertexColor = 19,
} Algo_MapType;

typedef struct {
   Algo_MapType type;
   Scene_PropertyValueList properties;
} Algo_BakeMap;

PXZ_EXPORTED void Algo_BakeMap_init(Algo_BakeMap * str);
PXZ_EXPORTED void Algo_BakeMap_free(Algo_BakeMap * str);
typedef struct {
   size_t size;
   Algo_BakeMap * list;
} Algo_BakeMapList;

PXZ_EXPORTED void Algo_BakeMapList_init(Algo_BakeMapList * list, size_t size = 0);
PXZ_EXPORTED void Algo_BakeMapList_free(Algo_BakeMapList * list);
typedef struct {
   Core_Boolean diffuse;
   Core_Boolean normal;
   Core_Boolean roughness;
   Core_Boolean metallic;
   Core_Boolean opacity;
   Core_Boolean ambientOcclusion;
   Core_Boolean emissive;
} Algo_BakeMaps;

PXZ_EXPORTED void Algo_BakeMaps_init(Algo_BakeMaps * str);
PXZ_EXPORTED void Algo_BakeMaps_free(Algo_BakeMaps * str);
typedef struct {
   Core_Int resolution;
   Core_Int padding;
   Algo_BakeMaps textures;
} Algo_BakeOption;

PXZ_EXPORTED void Algo_BakeOption_init(Algo_BakeOption * str);
PXZ_EXPORTED void Algo_BakeOption_free(Algo_BakeOption * str);
typedef enum {
 Algo_BakingMethod_RayOnly = 0,
 Algo_BakingMethod_ProjOnly = 1,
 Algo_BakingMethod_RayAndProj = 2,
} Algo_BakingMethod;

typedef struct {
   Geom_Affine position;
   Core_Double length;
   Core_Double height;
   Core_Double depth;
} Algo_Box;

PXZ_EXPORTED void Algo_Box_init(Algo_Box * str);
PXZ_EXPORTED void Algo_Box_free(Algo_Box * str);
typedef struct {
   Core_Double SizeX;
   Core_Double SizeY;
   Core_Double SizeZ;
   Core_Int Subdivision;
} Algo_BoxParameters;

PXZ_EXPORTED void Algo_BoxParameters_init(Algo_BoxParameters * str);
PXZ_EXPORTED void Algo_BoxParameters_free(Algo_BoxParameters * str);
typedef struct {
   Scene_Occurrence Root;
   CAD_BrickDefinitionList Bricks;
} Algo_BricksReturn;

PXZ_EXPORTED void Algo_BricksReturn_init(Algo_BricksReturn * str);
PXZ_EXPORTED void Algo_BricksReturn_free(Algo_BricksReturn * str);
typedef struct {
   Core_Double Radius;
   Core_Double Height;
   Core_Int Latitude;
   Core_Int Longitude;
} Algo_CapsuleParameters;

PXZ_EXPORTED void Algo_CapsuleParameters_init(Algo_CapsuleParameters * str);
PXZ_EXPORTED void Algo_CapsuleParameters_free(Algo_CapsuleParameters * str);
typedef enum {
 Algo_ComputingQuality_High = 0,
 Algo_ComputingQuality_Medium = 1,
 Algo_ComputingQuality_Low = 2,
} Algo_ComputingQuality;

typedef struct {
   Core_Double BottomRadius;
   Core_Double Height;
   Core_Int Sides;
} Algo_ConeParameters;

PXZ_EXPORTED void Algo_ConeParameters_init(Algo_ConeParameters * str);
PXZ_EXPORTED void Algo_ConeParameters_free(Algo_ConeParameters * str);
typedef enum {
 Algo_ConvexityFilter_OnConvex = 0,
 Algo_ConvexityFilter_OnConcave = 1,
 Algo_ConvexityFilter_OnConvexAndConcave = 2,
} Algo_ConvexityFilter;

typedef enum {
 Algo_CostEvaluation_SumEvaluation = 0,
 Algo_CostEvaluation_MaxEvaluation = 1,
 Algo_CostEvaluation_AverageEvaluation = 2,
} Algo_CostEvaluation;

typedef enum {
 Algo_CreateOccluder_Occludee = 0,
 Algo_CreateOccluder_Occluder = 1,
} Algo_CreateOccluder;

typedef struct {
   Core_String name;
   Core_Int component;
} Algo_CustomBakeMap;

PXZ_EXPORTED void Algo_CustomBakeMap_init(Algo_CustomBakeMap * str);
PXZ_EXPORTED void Algo_CustomBakeMap_free(Algo_CustomBakeMap * str);
typedef struct {
   size_t size;
   Algo_CustomBakeMap * list;
} Algo_CustomBakeMapList;

PXZ_EXPORTED void Algo_CustomBakeMapList_init(Algo_CustomBakeMapList * list, size_t size = 0);
PXZ_EXPORTED void Algo_CustomBakeMapList_free(Algo_CustomBakeMapList * list);
typedef struct {
   Geom_Affine position;
   Core_Double radius;
   Core_Double length;
} Algo_Cylinder;

PXZ_EXPORTED void Algo_Cylinder_init(Algo_Cylinder * str);
PXZ_EXPORTED void Algo_Cylinder_free(Algo_Cylinder * str);
typedef struct {
   Core_Double Radius;
   Core_Double Height;
   Core_Int Sides;
} Algo_CylinderParameters;

PXZ_EXPORTED void Algo_CylinderParameters_init(Algo_CylinderParameters * str);
PXZ_EXPORTED void Algo_CylinderParameters_free(Algo_CylinderParameters * str);
struct Algo_DecimateOptionsSelector {
   Core_ULong triangleCount;
   Core_Percent ratio;
   typedef enum {
      UNKNOWN=0,
      TRIANGLECOUNT,
      RATIO
   } Type;

   Type _type; 
};

PXZ_EXPORTED void Algo_DecimateOptionsSelector_init(Algo_DecimateOptionsSelector * sel);
PXZ_EXPORTED void Algo_DecimateOptionsSelector_free(Algo_DecimateOptionsSelector * sel);

typedef enum {
 Algo_DiskSegmentationMethod_Perimeter = 0,
 Algo_DiskSegmentationMethod_GaussianCurvature = 1,
} Algo_DiskSegmentationMethod;

typedef enum {
 Algo_ElementFilter_Polygons = 0,
 Algo_ElementFilter_Points = 1,
 Algo_ElementFilter_Hybrid = 2,
} Algo_ElementFilter;

typedef enum {
 Algo_FeatureType_Unknown = 0,
 Algo_FeatureType_ThroughHole = 1,
 Algo_FeatureType_BlindHole = 2,
} Algo_FeatureType;

typedef struct {
   Geom_Point3 position;
   Geom_Vector3 direction;
   Geom_Distance diameter;
} Algo_FeatureInput;

PXZ_EXPORTED void Algo_FeatureInput_init(Algo_FeatureInput * str);
PXZ_EXPORTED void Algo_FeatureInput_free(Algo_FeatureInput * str);
typedef struct {
   size_t size;
   Algo_FeatureInput * list;
} Algo_FeatureInputList;

PXZ_EXPORTED void Algo_FeatureInputList_init(Algo_FeatureInputList * list, size_t size = 0);
PXZ_EXPORTED void Algo_FeatureInputList_free(Algo_FeatureInputList * list);
typedef struct {
   Algo_FeatureType type;
   Algo_FeatureInputList inputs;
} Algo_Feature;

PXZ_EXPORTED void Algo_Feature_init(Algo_Feature * str);
PXZ_EXPORTED void Algo_Feature_free(Algo_Feature * str);
typedef struct {
   size_t size;
   Algo_Feature * list;
} Algo_FeatureList;

PXZ_EXPORTED void Algo_FeatureList_init(Algo_FeatureList * list, size_t size = 0);
PXZ_EXPORTED void Algo_FeatureList_free(Algo_FeatureList * list);
typedef enum {
 Algo_FilletingMode_Width = 0,
 Algo_FilletingMode_Distance = 1,
 Algo_FilletingMode_Depth = 2,
 Algo_FilletingMode_Radius = 3,
} Algo_FilletingMode;

typedef enum {
 Algo_FlatteningStopCondition_MEAN_DEFORMATION = 0,
 Algo_FlatteningStopCondition_ABSOLUTE_DEFORMATION = 1,
} Algo_FlatteningStopCondition;

typedef struct {
   Core_Double XLength;
   Core_Double YLength;
   Core_Double ZLength;
} Algo_HexahedronParameters;

PXZ_EXPORTED void Algo_HexahedronParameters_init(Algo_HexahedronParameters * str);
PXZ_EXPORTED void Algo_HexahedronParameters_free(Algo_HexahedronParameters * str);
typedef enum {
 Algo_InnerOuterOption_All = 0,
 Algo_InnerOuterOption_OnlyOuter = 1,
 Algo_InnerOuterOption_OnlyInners = 2,
} Algo_InnerOuterOption;

typedef struct {
   size_t size;
   Algo_MapType * list;
} Algo_MapTypeList;

PXZ_EXPORTED void Algo_MapTypeList_init(Algo_MapTypeList * list, size_t size = 0);
PXZ_EXPORTED void Algo_MapTypeList_free(Algo_MapTypeList * list);
typedef enum {
 Algo_MeshBooleanOperation_SplitOnly = 0,
 Algo_MeshBooleanOperation_Union = 1,
 Algo_MeshBooleanOperation_Intersection = 2,
 Algo_MeshBooleanOperation_Subtraction = 3,
} Algo_MeshBooleanOperation;

typedef struct {
   Scene_Occurrence occurrence;
   Algo_FeatureList features;
} Algo_OccurrenceFeatures;

PXZ_EXPORTED void Algo_OccurrenceFeatures_init(Algo_OccurrenceFeatures * str);
PXZ_EXPORTED void Algo_OccurrenceFeatures_free(Algo_OccurrenceFeatures * str);
typedef struct {
   size_t size;
   Algo_OccurrenceFeatures * list;
} Algo_OccurrenceFeaturesList;

PXZ_EXPORTED void Algo_OccurrenceFeaturesList_init(Algo_OccurrenceFeaturesList * list, size_t size = 0);
PXZ_EXPORTED void Algo_OccurrenceFeaturesList_free(Algo_OccurrenceFeaturesList * list);
typedef struct {
   Geom_Matrix4 OctaTransform;
   Core_Double Radius;
   Material_Image NormalMap;
   Material_Image DepthMap;
   Material_Image DiffuseMap;
   Material_Image MetallicMap;
   Material_Image AOMap;
   Material_Image RoughnessMap;
} Algo_OctahedralImpostor;

PXZ_EXPORTED void Algo_OctahedralImpostor_init(Algo_OctahedralImpostor * str);
PXZ_EXPORTED void Algo_OctahedralImpostor_free(Algo_OctahedralImpostor * str);
typedef enum {
 Algo_OrientStrategy_ExteriorOnly = 0,
 Algo_OrientStrategy_VisibilityOrExterior = 1,
 Algo_OrientStrategy_VisibilityByConnected = 2,
 Algo_OrientStrategy_VisibilityByPolygon = 3,
 Algo_OrientStrategy_ConformToMajority = 4,
} Algo_OrientStrategy;

typedef enum {
 Algo_OrientStrategyAdvanced_VisibilityByConnected = 0,
 Algo_OrientStrategyAdvanced_VisibilityByPolygon = 1,
} Algo_OrientStrategyAdvanced;

typedef struct {
   Geom_Affine position;
   Core_Double length;
   Core_Double height;
} Algo_Plane;

PXZ_EXPORTED void Algo_Plane_init(Algo_Plane * str);
PXZ_EXPORTED void Algo_Plane_free(Algo_Plane * str);
typedef struct {
   Core_Double SizeX;
   Core_Double SizeY;
   Core_Int SubdivisionX;
   Core_Int SubdivisionY;
} Algo_PlaneParameters;

PXZ_EXPORTED void Algo_PlaneParameters_init(Algo_PlaneParameters * str);
PXZ_EXPORTED void Algo_PlaneParameters_free(Algo_PlaneParameters * str);
typedef struct {
   Core_Double Radius;
   Core_Int Latitude;
   Core_Int Longitude;
} Algo_SphereParameters;

PXZ_EXPORTED void Algo_SphereParameters_init(Algo_SphereParameters * str);
PXZ_EXPORTED void Algo_SphereParameters_free(Algo_SphereParameters * str);
struct Algo_PrimitiveShapeParameters {
   Algo_BoxParameters Box;
   Algo_PlaneParameters Plane;
   Algo_SphereParameters Sphere;
   Algo_CylinderParameters Cylinder;
   Algo_ConeParameters Cone;
   Algo_CapsuleParameters Capsule;
   typedef enum {
      UNKNOWN=0,
      BOX,
      PLANE,
      SPHERE,
      CYLINDER,
      CONE,
      CAPSULE
   } Type;

   Type _type; 
};

PXZ_EXPORTED void Algo_PrimitiveShapeParameters_init(Algo_PrimitiveShapeParameters * sel);
PXZ_EXPORTED void Algo_PrimitiveShapeParameters_free(Algo_PrimitiveShapeParameters * sel);

typedef enum {
 Algo_QualityMemoryTradeoff_PreferQuality = 0,
 Algo_QualityMemoryTradeoff_PreferMemory = 1,
} Algo_QualityMemoryTradeoff;

typedef enum {
 Algo_QualitySpeedTradeoff_PreferQuality = 0,
 Algo_QualitySpeedTradeoff_PreferSpeed = 1,
} Algo_QualitySpeedTradeoff;

typedef enum {
 Algo_RatioUV3DMode_SmallestRatio = 0,
 Algo_RatioUV3DMode_HighestRatio = 1,
 Algo_RatioUV3DMode_AverageRatio = 2,
 Algo_RatioUV3DMode_MedianRatio = 3,
} Algo_RatioUV3DMode;

typedef enum {
 Algo_RelaxUVMethod_Angle = 0,
 Algo_RelaxUVMethod_Edge = 1,
} Algo_RelaxUVMethod;

typedef enum {
 Algo_ReplaceByBoxType_Minimum = 0,
 Algo_ReplaceByBoxType_LocallyAligned = 1,
} Algo_ReplaceByBoxType;

typedef enum {
 Algo_ReplaceByMode_ByOccurrence = 0,
 Algo_ReplaceByMode_All = 1,
} Algo_ReplaceByMode;

typedef struct {
   Scene_Occurrence Occurrence;
   Core_Boolean Aligned;
} Algo_ReplaceByOccurrenceOptions;

PXZ_EXPORTED void Algo_ReplaceByOccurrenceOptions_init(Algo_ReplaceByOccurrenceOptions * str);
PXZ_EXPORTED void Algo_ReplaceByOccurrenceOptions_free(Algo_ReplaceByOccurrenceOptions * str);
typedef struct {
   Algo_PrimitiveShapeParameters Type;
   Core_Boolean Aligned;
   Core_Boolean GenerateUV;
} Algo_ReplaceByPrimitiveOptions;

PXZ_EXPORTED void Algo_ReplaceByPrimitiveOptions_init(Algo_ReplaceByPrimitiveOptions * str);
PXZ_EXPORTED void Algo_ReplaceByPrimitiveOptions_free(Algo_ReplaceByPrimitiveOptions * str);
struct Algo_ReplaceByOption {
   Algo_ReplaceByOccurrenceOptions Occurrence;
   Algo_ReplaceByBoxType BoundingBox;
   Core_None ConvexHull;
   Algo_ReplaceByPrimitiveOptions Primitive;
   typedef enum {
      UNKNOWN=0,
      OCCURRENCE,
      BOUNDINGBOX,
      CONVEXHULL,
      PRIMITIVE
   } Type;

   Type _type; 
};

PXZ_EXPORTED void Algo_ReplaceByOption_init(Algo_ReplaceByOption * sel);
PXZ_EXPORTED void Algo_ReplaceByOption_free(Algo_ReplaceByOption * sel);

typedef enum {
 Algo_SawingMode_SawOnly = 0,
 Algo_SawingMode_SawAndSplit = 1,
 Algo_SawingMode_KeepInside = 2,
 Algo_SawingMode_KeepOutside = 3,
} Algo_SawingMode;

typedef enum {
 Algo_SelectionLevel_Parts = 0,
 Algo_SelectionLevel_Patches = 1,
 Algo_SelectionLevel_Polygons = 2,
} Algo_SelectionLevel;

typedef struct {
   Geom_Affine position;
   Core_Double radius;
} Algo_Sphere;

PXZ_EXPORTED void Algo_Sphere_init(Algo_Sphere * str);
PXZ_EXPORTED void Algo_Sphere_free(Algo_Sphere * str);
typedef enum {
 Algo_TransformationType_TRSOnly = 0,
 Algo_TransformationType_TRSAndSkew = 1,
} Algo_TransformationType;

typedef enum {
 Algo_UVGenerationMode_NoUV = 0,
 Algo_UVGenerationMode_IntrinsicUV = 1,
 Algo_UVGenerationMode_ConformalScaledUV = 2,
} Algo_UVGenerationMode;

typedef enum {
 Algo_UVImportanceEnum_PreserveSeamsAndReduceDeformation = 0,
 Algo_UVImportanceEnum_PreserveSeams = 1,
 Algo_UVImportanceEnum_IgnoreUV = 2,
} Algo_UVImportanceEnum;

typedef enum {
 Algo_UnwrapUVMethod_Isometric = 0,
 Algo_UnwrapUVMethod_Conformal = 1,
} Algo_UnwrapUVMethod;

struct Algo_UseColorOption {
   Core_None UseLinesColor;
   Core_Color ChooseColor;
   typedef enum {
      UNKNOWN=0,
      USELINESCOLOR,
      CHOOSECOLOR
   } Type;

   Type _type; 
};

PXZ_EXPORTED void Algo_UseColorOption_init(Algo_UseColorOption * sel);
PXZ_EXPORTED void Algo_UseColorOption_free(Algo_UseColorOption * sel);

typedef enum {
 Algo_VisibilityToWeightMode_FrontCountOnly = 0,
 Algo_VisibilityToWeightMode_FrontAndBackCount = 1,
 Algo_VisibilityToWeightMode_FrontCountOnlyAreaWeighted = 2,
 Algo_VisibilityToWeightMode_FrontAndBackCountAreaWeighted = 3,
} Algo_VisibilityToWeightMode;

typedef Core_ColorAlpha (*Algo_getPixelValue)(Geom_Point3 fromPos, Geom_Point2 param, Core_ULong polygonIndex, Scene_Occurrence occurrence);

typedef struct {
   size_t size;
   Algo_getPixelValue * list;
} Algo_getPixelValueList;

PXZ_EXPORTED void Algo_getPixelValueList_init(Algo_getPixelValueList * list, size_t size = 0);
PXZ_EXPORTED void Algo_getPixelValueList_free(Algo_getPixelValueList * list);


#endif
