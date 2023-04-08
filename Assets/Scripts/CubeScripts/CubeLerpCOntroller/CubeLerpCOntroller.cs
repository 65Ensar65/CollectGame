using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class CubeLerpController : ICubelable
{
    private Transform cubeTransform;
    private List<Transform> pointTransform = new List<Transform>();
    private float lerpSpeed;
    private float pointDistance;
    public void CubeChaseController()
    {
        for (int i = 0; i < pointTransform.Count; i++)
        {
            var pointdistance = cubeTransform.position - pointTransform[i].position;

            if (pointdistance.magnitude < pointDistance)
            {
                cubeTransform.position = Vector3.Lerp(cubeTransform.position, pointTransform[i].position, lerpSpeed * Time.deltaTime);
            }
        }
    }

    public void GetCubeParameters(Transform transform, List<Transform> target, float lerpSpeed, float pointDistance)
    {
        pointTransform = target;
        cubeTransform = transform;
        this.lerpSpeed = lerpSpeed;
        this.pointDistance = pointDistance;
    }

    public void CubeMeshController(GameObject gameObject, MeshRenderer meshRenderer, Material cubeMaterial, string layerName, float lerpSpeed)
    {
        meshRenderer.material.color = cubeMaterial.color;
        gameObject.layer = LayerMask.NameToLayer(layerName);
        gameObject.AddComponent<PointerCubeController>();
    }
}
