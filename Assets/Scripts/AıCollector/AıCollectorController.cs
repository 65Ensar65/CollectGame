using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AıCollectorController : Base,IInteract
{
    ObjectType objectType = ObjectType.AICollect;
    public void Interact(ObjectType type, Transform transform, Action<ObjectType, Transform> action)
    {
        switch (type)
        {
            case ObjectType.Collector:
                break;
            case ObjectType.Cube:
                action.Invoke(objectType, this.transform);
                break;
            default:
                break;
        }
    }
}
