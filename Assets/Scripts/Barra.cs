using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Barra : MonoBehaviour
{
    public Slider slider;
    public float cantidadVida;
    void Start()
    {
        slider = GetComponent<Slider>();
        Eventos.evento += BarraVida;
    }

    public void CambiarVidaMaxima (float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }

    public void CambiarVidaActual (float cantidadVida)
    {
        slider.value = cantidadVida;
    }

    public void InicializarBarraDeVida (float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }

    public void BarraVida(){
         CambiarVidaMaxima(cantidadVida);
         Debug.Log ("Consumiste parte de tu vida");
    } 

   
}
