using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GeneradorDePlatos : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    public Transform posicionGenerador;
    public Rigidbody2D mueble;
    public GameObject prefab;
    public int cont;
    public PlayerInputActions playerInputActions;
    public PlayerInput PlayerInput;
    public GameObject nuevo ;

    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player1"))
        {
            
            isInside= true;
            print("HOLAmUNDO");
            
        }
        
    }
    //Metodo que verifica si ya salio de la zona
    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player1"))
        {
            isInside = false;
            print("cHAOmUNDO");
        }
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)&& cont<3 && isInside)
            {
                
                nuevo = Instantiate(prefab,new Vector3(posicionGenerador.position.x,posicionGenerador.position.y,0),Quaternion.identity);
                nuevo.tag = "Plato";
                   
                cont++;
            } 
    }
   
}
