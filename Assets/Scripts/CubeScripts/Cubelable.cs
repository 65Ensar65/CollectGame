using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICubelable
{
    void CubeChaseController();
    void GetCubeParameters(Transform transform, List<Transform> target, float lerpSpeed, float pointDistance);
    void CubeMeshController(GameObject gameObject, MeshRenderer meshRenderer, Material cubeMaterial, string layerName, float lerpSpeed);
}

public interface ICubeControlable
{
    void GetCubeController(ObjectType objectType, Transform transform);
}

public interface IParticable
{
    void GetActiveParticle(ObjectPool objectPool, Transform cubeTransform);
    void GetPasivveParticle(ObjectPool objectPool, GameObject cubeGameobject);
}