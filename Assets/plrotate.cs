using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plrotate : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, transform.position.y, 0);
    }
}
