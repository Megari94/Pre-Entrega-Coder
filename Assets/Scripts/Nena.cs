using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Nena : Test
{
public Transform posNena;
public float velocidadNena = 5f; 
public Animator animation;  
    void Start()
    {
        Eventos.evento += SeguirJugador;
    }

    
    void Update() 
    {
          Movimiento();
          
       SeguirJugador();
         if(Input.GetKeyDown(KeyCode.Space)){
            animation.SetBool("nenaCorriendo", false);
       }else if(Input.GetKeyDown(KeyCode.W)){
            animation.SetBool("nenaCorriendo", false);
       }

       if(Input.GetKeyUp(KeyCode.Space)){
            animation.SetBool("nenaCorriendo", true);
       }else if(Input.GetKeyUp(KeyCode.W)){
            animation.SetBool("nenaCorriendo", true);
       }

       
    }

    void SeguirJugador(){
        if(Vector3.Distance(posNena.position, transform.position) > 1f){
             Vector3 direccion = (posNena.position - transform.position).normalized;
             transform.position += 5 * direccion * Time.deltaTime; 
    }}
}