using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawnerColorScripts : MonoBehaviour
{
    public TopHareketi TopHareketiScriptCall;
    void OnCollisionEnter()
    {
        // Pick a random, saturated and not-too-dark color
        GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

}
