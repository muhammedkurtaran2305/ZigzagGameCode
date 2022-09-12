using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    #region //Objects
    public Transform topkonum;
    Vector3 fark;
    #endregion

    #region //Camera Scripts
    void Start()
    {
        fark = transform.position - topkonum.position;
    }
    #endregion
    
    #region //CameraScrpits
    void Update()
    {
        if (TopHareketi.dustu_mu == false)
        {
            if (TopHareketi.dustu_mu==false)
            {
                transform.position = topkonum.position + fark;

            }
        }
        
    }
    #endregion
}
