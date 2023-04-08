using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour,IInteract
{
    ObjectType objectType = ObjectType.Plane;
    public void Interact(ObjectType type, Transform transform, Action<ObjectType, Transform> action)
    {
        switch (type)
        {
            case ObjectType.Cube:
                action.Invoke(objectType, this.transform);
                break;
            default:
                break;
        }
    }
}
