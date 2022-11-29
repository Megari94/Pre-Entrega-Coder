using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lorona : MonoBehaviour
{
    public Transform posLlorona;
    public float velocidad = 3f;
    
    
    public enum TipoDeEnemigo{
        vUno,
        vDos
    };
    public TipoDeEnemigo type;

    void Start()
    {
        Eventos.evento += SeguirJugador;
    }

    void Update()
    {
       switch (type) {
        case TipoDeEnemigo.vUno:
            MirarJugador();
            SeguirJugador();
            break;
        case TipoDeEnemigo.vDos:
            MirarJugador();
            
            break;
       }
        
        
       
        
    }

    void MirarJugador(){
         
        Quaternion jugador = Quaternion.LookRotation((posLlorona.position - transform.position));
        
        transform.rotation = Quaternion.Lerp(transform.rotation, jugador, velocidad * Time.deltaTime);
    }

    void SeguirJugador(){
        if(Vector3.Distance(posLlorona.position, transform.position) > 1f){
             Vector3 direccion = (posLlorona.position - transform.position).normalized;
             transform.position += 5 * direccion * Time.deltaTime; 
    }}

    void OnTriggerEnter(Collider col){
        if (col.transform.gameObject.name == "farol"){
            transform.position=new Vector3(65, 3, 1);
             MirarJugador();    
            }
    }
    
}

