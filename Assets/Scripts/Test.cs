using UnityEngine;

public class Test : MonoBehaviour
{
    
    
    public float speed;    
    public Animator animacion;
    public GameObject camUno;
    public GameObject camDos;

    void Start()
    {
       
    }
    void Update()
    {
       Movimiento();
       CambiarCamara();

       if(Input.GetKeyDown(KeyCode.Space)){
            animacion.SetBool("corriendo", true);
       }

       if(Input.GetKeyUp(KeyCode.Space)){
            animacion.SetBool("corriendo", false);
       }
       
    }

    

    void Movimiento(){
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movX, 0, movY) * speed * Time.deltaTime);;

        if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0, -5, 0);
        }
        if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0, 5, 0);
        }
    }

    void CambiarCamara(){
        if(Input.GetKeyDown(KeyCode.K)){
            camUno.SetActive(false);
            camDos.SetActive(true);
        }
         if(Input.GetKeyDown(KeyCode.J)){
            camUno.SetActive(true);
            camDos.SetActive(false);
        }
    }

 


 
    
}
