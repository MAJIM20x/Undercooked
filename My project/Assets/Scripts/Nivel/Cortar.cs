using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cortar : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria comidaAleatoria;
    public TimerReal timerReal;
    private GameObject vacio;
    private int tiempoHervir;   
    public Rigidbody2D rb;
    public bool isCortar = false;
    private bool cortar1;
    private bool cortar2;
    private bool cortar3;
    private bool cortar4;
    private bool cortar5;
    private bool cortar6;



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
                isCortar = true;
                cortar1 = true;
                comidaAleatoria.comida.SetActive(false);
                print("Arreglao");
                
                
            }
            else if(timerReal.segundosActuales == 4&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 59;
                isCortar = true;
                cortar2 = true;
                comidaAleatoria.comida.SetActive(false);
                
                

            }else if(timerReal.segundosActuales == 3&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 56;
                isCortar = true;
                cortar3 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
                
            }else if(timerReal.segundosActuales == 2&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 57;
                isCortar = true;
                cortar4 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
            }
            else if(timerReal.segundosActuales == 1&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 56;
                isCortar = true;
                cortar5 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
            
            }else if(timerReal.segundosActuales == 0&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 55;
                isCortar = true;
                cortar6 = true;
                comidaAleatoria.comida.SetActive(false);
            }
        }
        if(cortar1== true && tiempoHervir == timerReal.segundosActuales)
        {
            isCortar = false;
            cortar1 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 6)
            {
                comidaAleatoria.comida.layer = 14;
            }
            else if(comidaAleatoria.comida.layer == 10)
            {
                comidaAleatoria.comida.layer = 19;
            }
            else if(comidaAleatoria.comida.layer ==7)
            {
                comidaAleatoria.comida.layer =15;
            }
            
        }
        else if(cortar2 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isCortar = false;
            cortar2 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 6)
            {
                comidaAleatoria.comida.layer = 14;
            }
            else if(comidaAleatoria.comida.layer == 10)
            {
                comidaAleatoria.comida.layer = 19;
            }
            else if(comidaAleatoria.comida.layer ==7)
            {
                comidaAleatoria.comida.layer =15;
            }
            
        }
        else if(cortar3 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isCortar = false;
            cortar3 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 6)
            {
                comidaAleatoria.comida.layer = 14;
            }
            else if(comidaAleatoria.comida.layer == 10)
            {
                comidaAleatoria.comida.layer = 19;
            }
            else if(comidaAleatoria.comida.layer ==7)
            {
                comidaAleatoria.comida.layer =15;
            }
            
        }
        else if(cortar4 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isCortar = false;
            cortar4 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 6)
            {
                comidaAleatoria.comida.layer = 14;
            }
            else if(comidaAleatoria.comida.layer == 10)
            {
                comidaAleatoria.comida.layer = 19;
            }
            else if(comidaAleatoria.comida.layer ==7)
            {
                comidaAleatoria.comida.layer =15;
            }
            
        }
        else if(cortar5 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isCortar = false;
            cortar5 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 6)
            {
                comidaAleatoria.comida.layer = 14;
            }
            else if(comidaAleatoria.comida.layer == 10)
            {
                comidaAleatoria.comida.layer = 19;
            }
            else if(comidaAleatoria.comida.layer ==7)
            {
                comidaAleatoria.comida.layer =15;
            }
            
        }
        else if(cortar6 == true && tiempoHervir == timerReal.segundosActuales)
        {
            isCortar = false;
            cortar6 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 6)
            {
                comidaAleatoria.comida.layer = 14;
            }
            else if(comidaAleatoria.comida.layer == 10)
            {
                comidaAleatoria.comida.layer = 19;
            }
            else if(comidaAleatoria.comida.layer ==7)
            {
                comidaAleatoria.comida.layer =15;
            }
            
        }

    }
    private void Awake() 
    {
        comidaAleatoria = FindObjectOfType<ComodiaAleatoria>();
    }
  
}
