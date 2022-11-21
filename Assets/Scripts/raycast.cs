using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public float vida;
    public float vidaMaxima;
    public Barra barraDeVida;
    //public AudioSource audio;
    float maxDis= 50f;
    public LayerMask detectar;
    void Start()
    {
        vida = vidaMaxima;
        barraDeVida.InicializarBarraDeVida(vida);
    }

    
    void Update()
    {
       RaycastHit hit;
       Ray ray = new Ray(transform.position, transform.forward);
       
       
       if (Physics.Raycast(ray, out hit, maxDis, detectar)){
            //audio.Play();
            vida -= vidaMaxima;
            barraDeVida.CambiarVidaActual(vida);
            Debug.Log("RUN");
            
       }

    }
}
