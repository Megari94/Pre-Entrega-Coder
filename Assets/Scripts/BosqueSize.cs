using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BosqueSize : MonoBehaviour
{
    public GameObject Terrain;
    
    void Start()
    {
        Eventos.evento += BosqueLittle;
    }

    void BosqueLittle()
    {
        transform.localPosition = new Vector3 (54, 25, -34); 
    }
}
