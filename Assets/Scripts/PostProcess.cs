using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcess : MonoBehaviour
{
    private Bloom bloom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(1))
       {
            bloom.intensity.value = 0;

       }

       if(Input.GetMouseButtonDown(0))
       {
            bloom.intensity.value += Time.deltaTime; 
       }
    }
}
