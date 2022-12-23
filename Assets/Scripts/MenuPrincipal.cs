using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("demoScene_free");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    public void Menu() {
        {
            SceneManager.LoadScene("MenuInicio");
        }
    }
}
