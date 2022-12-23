using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Eventos : MonoBehaviour
{
    public static event Action evento;
    void Start()
    {
        
    }

    
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.H))
        {
            /* if(evento =! null)
            {
                evento();
            } */
            evento?.Invoke(); //sirve igual que el null 
        } 
    }
}
