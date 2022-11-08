using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Parka : MonoBehaviour

{
public Transform posParka;
public float velocidadParka = 3f;  
    void Start()
    {
        
    }

    
    void Update()
    {
       MirarJugador(); 
    }

    void MirarJugador(){
         
        Quaternion jugador = Quaternion.LookRotation((posParka.position - transform.position));
        
        transform.rotation = Quaternion.Lerp(transform.rotation, jugador, velocidadParka * Time.deltaTime);
    }
}
