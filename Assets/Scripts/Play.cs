using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject Pause;
    public void Reanudar(){
        Time.timeScale = 1f;
        Pause.SetActive(false);
    }
}
