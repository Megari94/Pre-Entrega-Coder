using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
   public GameObject Pause;

   void Start(){
      Pause.SetActive(false);
   }
   public void Pausa(){
     Time.timeScale = 0f;
      Pause.SetActive(true);
      
   }
}
