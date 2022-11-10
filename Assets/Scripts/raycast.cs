using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    //public AudioSource audio;
    float maxDis= 50f;
    public LayerMask detectar;
    void Start()
    {
        
    }

    
    void Update()
    {
       RaycastHit hit;
       Ray ray = new Ray(transform.position, transform.forward);
       
       
       if (Physics.Raycast(ray, out hit, maxDis, detectar)){
            //audio.Play();
            
            Debug.Log("RUN");
            
       }

    }
}
