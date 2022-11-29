using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CambiarColorLuz : MonoBehaviour
{
    public GameObject farol;
    void Start()
    {
        Eventos.evento += CambiarColor;
    }

     void CambiarColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    
}
