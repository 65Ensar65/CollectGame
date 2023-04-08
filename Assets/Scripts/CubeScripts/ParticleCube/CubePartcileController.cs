using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePartcileController : Base,IParticable
{
    public void GetActiveParticle(ObjectPool objectPool, Transform cubeTransform)
    {
        objectPool.ActivePoolObject(ObjectTag.CubeParticle, cubeTransform);
        GetPasivveParticle(objectPool, gameObject);
    }

    public void GetPasivveParticle(ObjectPool objectPool, GameObject cubeGameobject)
    {
        objectPool.ReturnPoolObject(ObjectTag.CubeParticle, gameObject);
    }
}
