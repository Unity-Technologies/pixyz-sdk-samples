import numpy as np
import numpy.linalg as linalg

def rotToEuler(R):
    beta = -np.arcsin(R[2,0])
    alpha = np.arctan2(R[2,1]/np.cos(beta),R[2,2]/np.cos(beta))
    gamma = np.arctan2(R[1,0]/np.cos(beta),R[0,0]/np.cos(beta))
    return np.array((alpha, beta, gamma))

def eulerToRot(theta) :
    return np.array([[np.cos(theta[1])*np.cos(theta[2]),       np.sin(theta[0])*np.sin(theta[1])*np.cos(theta[2]) - np.sin(theta[2])*np.cos(theta[0]),      np.sin(theta[1])*np.cos(theta[0])*np.cos(theta[2]) + np.sin(theta[0])*np.sin(theta[2]), 0.],
                  [np.sin(theta[2])*np.cos(theta[1]),       np.sin(theta[0])*np.sin(theta[1])*np.sin(theta[2]) + np.cos(theta[0])*np.cos(theta[2]),      np.sin(theta[1])*np.sin(theta[2])*np.cos(theta[0]) - np.sin(theta[0])*np.cos(theta[2]), 0.],
                  [-np.sin(theta[1]),                        np.sin(theta[0])*np.cos(theta[1]),                                                           np.cos(theta[0])*np.cos(theta[1]), 0.], [0,0,0,1]])

def toTRS(matrix : np.ndarray) -> (np.ndarray, np.ndarray, np.ndarray):
    if not isValidTrsMatrix(matrix):
        raise ValueError("Matrix is not a valid TRS matrix")
    scale = getScale(matrix)
    trans = np.array([matrix[0][3],matrix[1][3],matrix[2][3]])
    rotScale = matrix
    rotScale[0][3] = rotScale[1][3] = rotScale[2][3] = 0.
    scaleMat = np.identity(4, dtype=np.float32)
    for i in range(3):
        scaleMat[i][i] = scale[i]
    rot = np.matmul(rotScale, linalg.inv(scaleMat))
    return trans, rotToEuler(rot), scale

def fromTRS(trans, rot, scale):
    scaleMat = np.identity(4, dtype=np.float32)
    for i in range(3):
        scaleMat[i][i] = scale[i]
    mat = np.matmul(eulerToRot(rot), scaleMat)
    mat[0,3] = trans[0]
    mat[1,3] = trans[1]
    mat[2,3] = trans[2]
    return mat

def getScale(matrix):
    vecX = np.multiply(matrix, [1, 0, 0, 0])
    vecY = np.multiply(matrix, [0, 1, 0, 0])
    vecZ = np.multiply(matrix, [0, 0, 1, 0])
    return np.array((linalg.norm(vecX), linalg.norm(vecY), linalg.norm(vecZ)))

def isValidTrsMatrix(matrix):
    if matrix.shape != (4,4):
        return False
    if np.isclose(linalg.det(matrix), 0):
        return False
    return True
