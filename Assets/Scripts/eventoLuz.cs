using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class eventoLuz : MonoBehaviour
{
   
    public GameObject farol;
    void Start()
    {
        Eventos.evento += RangoLuz;
    }

    
    void Update()
    {
        
    }

    void RangoLuz(){
         transform.localScale = new Vector3 (2,2,2);
         Debug.Log ("CambiarTamanioLuz");
    }
}
