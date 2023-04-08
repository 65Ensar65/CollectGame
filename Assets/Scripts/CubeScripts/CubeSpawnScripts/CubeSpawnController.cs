using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnController : Base
{
    [SerializeField] float SpawnTime;
    [HideInInspector] public float SpawnCount = 0;
    [HideInInspector] public bool IsFree = true;
    void Start()
    {
        GetSpawnController();
    }

    public void GetSpawnController()
    {
        StartCoroutine(SpawnDelay(SpawnTime));
    }

    public IEnumerator SpawnDelay(float Time)
    {
        while (IsFree)
        {
            GameObject obj = e_objectPool.ActivePoolObject(ObjectTag.Cube, transform);
            obj.transform.position = transform.GetChild(0).position;
            obj.transform.parent = transform.GetChild(1);

            yield return new WaitForSeconds(Time);
        }
    }
}
