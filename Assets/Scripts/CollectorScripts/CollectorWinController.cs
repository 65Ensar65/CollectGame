using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorWinController : Base
{
    void Update()
    {
        if (transform.childCount == 0)
        {
            GameManager.Instance.GetWin();
        }    
    }
}
