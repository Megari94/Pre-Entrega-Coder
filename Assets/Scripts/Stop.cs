using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
   public void Pausa(){
    Time.timeScale = 0f;
   }
}
