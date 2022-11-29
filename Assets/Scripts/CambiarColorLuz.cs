using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CambiarColorLuz : MonoBehaviour
{
    public GameObject Light; 
    void Start()
    {
        Eventos.evento += CambiarColor;
    }

     void CambiarColor()
    {
        transform.Rotate(150, 34, 165);
        
    }

    
}
