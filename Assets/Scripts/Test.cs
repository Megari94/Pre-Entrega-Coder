using UnityEngine;

public class Test : MonoBehaviour
{
    public LayerMask detectar;
    float maxDis= 30f;
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

    

    void OnTriggerEnter(Collider col){
        if (col.transform.gameObject.name == "Llorona"){
            Debug.Log("Tu hermana ha sido secuestrada");
                
            }
    }

    void OnTriggerStay(Collider col){
        if (col.transform.gameObject.name == "farol"){
            Debug.Log("Estan a Salvo!!");
        }
    }

    void OnTriggerExit(Collider col){
        if (col.transform.gameObject.name == "farol"){
            Debug.Log("Vuelve a la luz!");
        }
    }


 
    
}
