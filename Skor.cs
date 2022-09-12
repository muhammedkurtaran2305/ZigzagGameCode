using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Skor : MonoBehaviour
{
   
    public static int skor;
    public Text skortext;
    public GameObject kupa;
    public TopHareketi topHareketi;
    void Start()
    {


        skor = 0;
        if (skor==0)
        {
            skortext.enabled = false;    
            kupa.SetActive(true);
        }
    }
   
    void Update()
    {
        if (skor !=0)
        {
            skortext.enabled = true;
            kupa.SetActive(false);
            skortext.text = skor.ToString();
            


        }
    }
   
}