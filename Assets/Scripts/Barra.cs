using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    public Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
        
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
}
