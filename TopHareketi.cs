using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TopHareketi : MonoBehaviour
{
    Vector3 yon;

    public float hiz;
    public zeminSpawner zeminSpawnerScriptCall;
    public static bool dustu_mu;
    public float eklenecekHiz;
    public AudioSource ses;
    public AudioClip sesClip;
    public void sesCalma()
    {
        ses.PlayOneShot(sesClip, 0.1f);
    }
    void Start()
    {       
        dustu_mu = false;
        yon = Vector3.forward;
    }
  
       

void Update()
    {
        transform.Rotate(Vector3.left, Time.deltaTime * 90);
        transform.Rotate(Vector3.right, Time.deltaTime * 90);
        transform.Rotate(Vector3.forward, Time.deltaTime * 180);


        if (transform.position.y<=-8.0f)
        {
            dustu_mu = true;
        }
        if (dustu_mu == true)
        {
            Destroy(gameObject, 0.1f);
            SceneManager.LoadScene("tryAgainScenes");
        }
        if (Input.GetMouseButtonDown(0))
        {
           if (Input.GetMouseButtonDown(0))
           {      
                sesCalma();

           }
           if (yon.x == 0)
           {
                yon = Vector3.left;
           }
           else
           {
                yon = Vector3.forward;
           }
           hiz += eklenecekHiz * Time.deltaTime;
        }       
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yon * Time.deltaTime * hiz;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>();
           zeminSpawnerScriptCall.zemin_Olustur();
            StartCoroutine(ZeminSil(collision.gameObject));
        }
    }
    IEnumerator ZeminSil(GameObject silinecekzemin)
    {
        yield return new WaitForSeconds(2f);
        Destroy(silinecekzemin);
    }


}
