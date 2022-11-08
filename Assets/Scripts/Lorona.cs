using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lorona : MonoBehaviour
{
    public Transform posLlorona;
    public float velocidad = 5f;
    public enum TipoDeEnemigo{
        vUno,
        vDos
    };
    public TipoDeEnemigo type;
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
        if(Vector3.Distance(posLlorona.position, transform.position) > 2f){
             Vector3 direccion = (posLlorona.position - transform.position).normalized;
             transform.position += 5 * direccion * Time.deltaTime; 
    }}

    
    
}

