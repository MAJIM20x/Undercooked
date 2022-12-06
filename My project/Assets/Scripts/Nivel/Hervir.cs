using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hervir : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria comidaAleatoria;
    public TimerReal timerReal;
    private GameObject vacio;
    private int tiempoHervir;   
    public Rigidbody2D rb;
    public bool isHervir = false;
    private bool hervir1;
    private bool hervir2;
    private bool hervir3;
    private bool hervir4;
    private bool hervir5;
    private bool hervir6;



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
    private void Update() {
        if(isInside == true &&Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("hola");
            print(timerReal.segundosActuales);
            if(timerReal.segundosActuales > 5 && timerReal.minutosActuales >= 0)
            {
                print("helloWort");
                tiempoHervir = timerReal.segundosActuales -5; 
                isHervir = true;
                hervir1 = true;
                comidaAleatoria.comida.SetActive(false);
                print("Arreglao");
                
                
            }
            else if(timerReal.segundosActuales == 4&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 59;
                isHervir = true;
                hervir2 = true;
                comidaAleatoria.comida.SetActive(false);
                
                

            }else if(timerReal.segundosActuales == 3&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 512;
                isHervir = true;
                hervir3 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
                
            }else if(timerReal.segundosActuales == 2&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 57;
                isHervir = true;
                hervir4 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
            }
            else if(timerReal.segundosActuales == 1&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 56;
                isHervir = true;
                hervir5 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
            
            }else if(timerReal.segundosActuales == 0&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 55;
                isHervir = true;
                hervir6 = true;
                comidaAleatoria.comida.SetActive(false);
            }
        }
        if(hervir1== true && tiempoHervir == timerReal.segundosActuales)
        {
            isHervir = false;
            hervir1 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 12)
            {
                comidaAleatoria.comida.layer = 20;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 21;
            }
            
        }
        else if(hervir2 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isHervir = false;
            hervir2 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 12)
            {
                comidaAleatoria.comida.layer = 20;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 21;
            }
            
        }
        else if(hervir3 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isHervir = false;
            hervir3 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 12)
            {
                comidaAleatoria.comida.layer = 20;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 21;
            }
            
        }
        else if(hervir4 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isHervir = false;
            hervir4 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 12)
            {
                comidaAleatoria.comida.layer = 20;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 21;
            }
            
        }
        else if(hervir5 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isHervir = false;
            hervir5 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 12)
            {
                comidaAleatoria.comida.layer = 20;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 21;
            }
            
        }
        else if(hervir6 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isHervir = false;
            hervir6 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 12)
            {
                comidaAleatoria.comida.layer = 20;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 21;
            }
            
        }

    }
    private void Awake() 
    {
        comidaAleatoria = FindObjectOfType<ComodiaAleatoria>();
    }
    
}
