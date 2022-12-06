using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocinarJuntar : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria comidaAleatoria;
    public TimerReal timerReal;
    private GameObject vacio;
    private int tiempoHervir;   
    public Rigidbody2D rb;
    public GameObject spawner;
    public GameObject[] prefrabs;
    public Transform posicion;


   
    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")  )
        {
          
            isInside= true;
            print("PintamosTodaLaCasa");
            
        }
        
    }
    //Metodo que verifica si ya salio de la zona
    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isInside = false;
            print("SinDejarCaerUnaGotaDeQueEsEsoo");
        }
    }
    private void Update() 
    {
        if(isInside)
        {
            if(comidaAleatoria.comida.layer ==21 && comidaAleatoria.comida.layer == 7 && comidaAleatoria.comida.layer == 23)
            {
            if(comidaAleatoria.comida.layer ==21)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 7)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 23)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[0], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =13;
  
            }
            else if(comidaAleatoria.comida.layer == 9 && comidaAleatoria.comida.layer == 18 && comidaAleatoria.comida.layer == 7)
            {
            if(comidaAleatoria.comida.layer ==9)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 18)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 7)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[1], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =14;
            }
            else if(comidaAleatoria.comida.layer == 22 && comidaAleatoria.comida.layer == 22 & comidaAleatoria.comida.layer == 19)
            {
            if(comidaAleatoria.comida.layer ==22)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 22)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 29)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[2], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =16;
            }
            else if(comidaAleatoria.comida.layer == 19 && comidaAleatoria.comida.layer == 19 && comidaAleatoria.comida.layer == 19)
            {
            if(comidaAleatoria.comida.layer ==19)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 19)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 19)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[3], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =15;
            }
            else if(comidaAleatoria.comida.layer == 24 &&comidaAleatoria.comida.layer == 20 &&comidaAleatoria.comida.layer == 3)
            {
            if(comidaAleatoria.comida.layer ==24)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 20)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 3)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[4], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =17;
            }
        
        }
    }
        
        

    
    private void Awake() 
    {
        comidaAleatoria = FindObjectOfType<ComodiaAleatoria>();
    }
    
}
