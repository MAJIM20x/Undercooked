using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregaDePlato : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    public Transform[] posicionPlato;
    public Rigidbody2D mueble;
    public PlayerInputActions playerInputActions;
    public Cliente cliente;
    public GeneradorDePlatos generadorDePlatos;
    TimerReal tiempo;

    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player1") && other.gameObject.CompareTag("Plato"))
        {
            
            isInside= true;
            print("HOLAmUNDO");
            
        }
        
    }
    //Metodo que verifica si ya salio de la zona
    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player1") && other.gameObject.CompareTag("Plato"))
        {
            isInside = false;
            print("cHAOmUNDO");
        }
    }
    // update
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && isInside)
            {
                
                
                
                generadorDePlatos.nuevo.SetActive(false);
                int condicion = tiempo.segundosActuales- 5;
                generadorDePlatos.cont--;
                
                
                
            } 
    }
}
