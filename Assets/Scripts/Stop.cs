using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stop : MonoBehaviour
{
   public GameObject Pause;

   void Start(){
      
   }
   void Update()
      {
         Pausa();
         Return();
         Esc();
      }
   public void Pausa()
   {
     if (Input.GetKeyDown(KeyCode.Space)){
         Time.timeScale = 0f;
     }
   }
   public void Return()
   {
      if (Input.GetKeyDown(KeyCode.R)){
         Time.timeScale = 1f;
     }
   }
   public void Esc()
   {
      if (Input.GetKeyDown(KeyCode.Escape)){
         SceneManager.LoadScene("MenuInicio");
     }
   }

}
