import math
import pxz
from pxz import scene, algo, material, core

def bakeMaterials(destination: list[int], source: list[int], resolution: int, padding: int, oneToOne: bool,
                  gpuBaking: bool, channel: int = 0, tolerance: float = -1, overrideUVs: bool = True, offset: float = 0,
                  upScaling: int = 1):

    if upScaling > 1:
        resolution *= upScaling
        padding *= upScaling

    if overrideUVs:
        algo.mapUvOnAABB(destination, False, 1, channel, overrideUVs)  # generate UVs (mandatory before baking)
        algo.repackUV(destination, channel, True, resolution, padding * 2, uniformRatio=True)  # repack UVs (mandatory before baking)
        algo.normalizeUV(destination, channel, channel, False)

        # normalization stick the UVs on boundaries
        # offset and rescale to add padding on UV space boundaries
        o = padding / resolution
        s = 1 - 2 * o
        uvMatrix = geom.IdentityMatrix4
        uvMatrix[0][0] = uvMatrix[1][1] = s
        uvMatrix[0][3] = uvMatrix[1][3] = o
        algo.applyUvTransform(destination, uvMatrix, channel)

    algo.createTangents(destination, channel, override=False)

    core.setModuleProperty("Algo", "UseGPUBaking", "True" if gpuBaking else "False")

    outputImages = algo.bakeMaps(destination, source, [
        algo.BakeMap(algo.MapType.Diffuse, []),
        algo.BakeMap(algo.MapType.AO, []),
        algo.BakeMap(algo.MapType.Emissive, []),
        algo.BakeMap(algo.MapType.Metallic, []),
        algo.BakeMap(algo.MapType.Normal, []),
        algo.BakeMap(algo.MapType.Roughness, []),
        algo.BakeMap(algo.MapType.Opacity, [])],
        channel=channel,
        resolution=resolution,
        padding=padding,
        tolerance=tolerance,
        method=algo.BakingMethod.RayOnly,
        opacityThreshold=0.3,
        oneToOne=oneToOne,
        offset=offset)

    # Set up material with baked maps
    newMaterial = material.createMaterial("Baked", "PBR")

    core.setProperty(newMaterial, "albedo", "TEXTURE([[1,1],[0,0]," + str(outputImages[0]) + ", 0])")
    core.setProperty(newMaterial, "ao", "TEXTURE([[1,1],[0,0]," + str(outputImages[1]) + ", 0])")
    core.setProperty(newMaterial, "emissive", "TEXTURE([[1,1],[0,0]," + str(outputImages[2]) + ", 0])")
    core.setProperty(newMaterial, "metallic", "TEXTURE([[1,1],[0,0]," + str(outputImages[3]) + ", 0])")

    algo.convertNormalMap(destination, outputImages[4], channel, True, False, True, True, True)
    core.setProperty(newMaterial, "normal", "TEXTURE([[1,1],[0,0]," + str(outputImages[4]) + ", 0])")

    core.setProperty(newMaterial, "roughness", "TEXTURE([[1,1],[0,0]," + str(outputImages[5]) + ", 0])")
    core.setProperty(newMaterial, "opacity", "TEXTURE([[1,1],[0,0]," + str(outputImages[6]) + ", 0])")

    for occ in destination:
        core.setProperty(occ, "Material", str(newMaterial))

    if upScaling > 1:
        resolution /= upScaling
        for i in range(len(outputImages)):
            pxz.material.resizeImage(outputImages[i], resolution, resolution)

