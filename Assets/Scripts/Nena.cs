using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Nena : MonoBehaviour
{
public Transform posNena;
public float velocidadNena = 5f; 
public Animator animacion;  
    void Start()
    {
        
    }

    
    void Update()
    {
       SeguirJugador();
         if(Input.GetKeyDown(KeyCode.Space)){
            animacion.SetBool("nenaCorriendo", false);
       }

       if(Input.GetKeyUp(KeyCode.Space)){
            animacion.SetBool("nenaCorriendo", true);
       }
    }

    void SeguirJugador(){
        if(Vector3.Distance(posNena.position, transform.position) > 1f){
             Vector3 direccion = (posNena.position - transform.position).normalized;
             transform.position += 5 * direccion * Time.deltaTime; 
    }}
}