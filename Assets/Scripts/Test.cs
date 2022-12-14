
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour
{
    public LayerMask detectar;
    float maxDis= 30f;
    public float speed;    
    public Animator animacion;
    public GameObject camUno;
    public GameObject camDos;
    public List<Transform> posAleatorea = new List<Transform>();
    
    void Start()
    {
       transform.position = posAleatorea[Random.Range(0, posAleatorea.Count-1)].position;
       foreach (Transform b in posAleatorea ){
        Debug.Log("Busca a tu hermana");
       }
    }
    void Update()
    {
       Movimiento();
        
        
        if(Input.GetKeyDown(KeyCode.Space)){
            animacion.SetBool("corriendo", true);
       }else if(Input.GetKeyDown(KeyCode.W)){
            animacion.SetBool("corriendo", true);
       }

       if(Input.GetKeyUp(KeyCode.Space)){
            animacion.SetBool("corriendo", false);
       }else if(Input.GetKeyUp(KeyCode.W)){
            animacion.SetBool("corriendo", false);
       }

     
       
       RaycastHit hit;
       Ray rayc = new Ray(transform.position, transform.forward);
       
       
       if (Physics.Raycast(rayc, out hit, maxDis, detectar)){
            
            
            Debug.Log("HURRY UP!!");
            
       }
       
      
       
    }

    
       
    
    

    public void Movimiento(){
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

    

    void OnTriggerEnter(Collider col){
        if (col.transform.gameObject.name == "Llorona"){
            Debug.Log("Tu hermana ha sido secuestrada");
            SceneManager.LoadScene("GameOver");
                
            }
    }

    void OnTriggerStay(Collider col){
        if (col.transform.gameObject.name == "farol"){
            SceneManager.LoadScene("Winner");
            Debug.Log("Estan a Salvo!!");
        }
    }

    void OnTriggerExit(Collider col){
        if (col.transform.gameObject.name == "farol"){
            Debug.Log("Vuelve a la luz!");
        }
    }


 
    
}
