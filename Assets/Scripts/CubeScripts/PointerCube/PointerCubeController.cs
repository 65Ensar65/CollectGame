using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerCubeController : Base, IInteract
{
    ObjectType objectType = ObjectType.PointerCube;
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
