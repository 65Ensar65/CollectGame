using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEditor.UIElements;
using System;

public class CubeController : Base, ICubeControlable
{
    private ICubelable cubeLable;
    private string layerName = "Cubes";

    public ObjectType type;

    [Title("Cube Lerp Values")]
    [SerializeField] public List<Transform> Target = new List<Transform>();
    [SerializeField] float LerpSpeed;
    [SerializeField] float PointDistance;

    [Title("Cube Mesh Values")]
    [SerializeField] Material CubeMat;
    void Start()
    {
        cubeLable = new CubeLerpController();

        cubeLable.GetCubeParameters(transform, Target, LerpSpeed, PointDistance);

    }

    private void FixedUpdate()
    {
        cubeLable.CubeChaseController();
    }

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<IInteract>()?.Interact(type, transform, GetCubeController);
    }

    public void GetCubeController(ObjectType objectType, Transform transform)
    {
        switch (objectType)
        {
            case ObjectType.Point:
                cubeLable.CubeMeshController(gameObject, e_meshRenderer, CubeMat, layerName, LerpSpeed);
                this.transform.parent = transform.parent;
                type = ObjectType.PointerCube;
                LerpSpeed = .5f;
                break;

            case ObjectType.PointerCube:
                cubeLable.CubeMeshController(gameObject, e_meshRenderer, CubeMat, layerName, LerpSpeed);
                this.transform.parent = transform.parent;
                type = ObjectType.PointerCube;
                LerpSpeed = .5f;
                break;

            case ObjectType.CollectPoint:
                e_objectPool.ReturnPoolObject(ObjectTag.Cube, gameObject);
                GameManager.Instance.CollectorCubeIndex++;
                break;

            case ObjectType.AIPoint:
                e_objectPool.ReturnPoolObject(ObjectTag.Cube, gameObject);
                if (GameManager.Instance.IsTextFree)
                {
                    GameManager.Instance.AICollectorCubeIndex++;
                }
                break;

            case ObjectType.AICollect:
                gameObject.layer = LayerMask.NameToLayer(layerName);
                break;

            case ObjectType.Plane:
                gameObject.layer = LayerMask.NameToLayer("Default");
                break;
            default:
                break;
        }
    }
}
