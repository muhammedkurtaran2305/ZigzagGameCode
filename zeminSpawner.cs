using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminSpawner : MonoBehaviour
{

    
    public GameObject son_Zemin;
    void Start()
    {

        for (int i = 0; i < 15; i++)
        {
            zemin_Olustur();
        }
    }
 
    public void zemin_Olustur()

    {

        Vector3 yon;
        if (Random.Range(0,2) == 0) 
        {
            yon = Vector3.left;
        }
        else
        {
            yon = Vector3.forward;
        }
        son_Zemin = Instantiate(son_Zemin, son_Zemin.transform.position + yon, son_Zemin.transform.rotation);
    }
}
