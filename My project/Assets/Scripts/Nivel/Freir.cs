using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freir : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria comidaAleatoria;
    public TimerReal timerReal;
    private GameObject vacio;
    private int tiempoFreir;   
    public Rigidbody2D rb;
    public bool isFriendo = false;
    public bool friendo1;
    public bool friendo2;
    public bool friendo3;
    public bool friendo4;
    public bool friendo5;
    public bool friendo6;



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
                tiempoFreir = timerReal.segundosActuales -5; 
                isFriendo = true;
                friendo1 = true;
                comidaAleatoria.comida.SetActive(false);
                print("Arreglao");
                
                
            }
            else if(timerReal.segundosActuales == 4&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 59;
                isFriendo = true;
                friendo2 = true;
                comidaAleatoria.comida.SetActive(false);
                
                

            }else if(timerReal.segundosActuales == 3&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 58;
                isFriendo = true;
                friendo3 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
                
            }else if(timerReal.segundosActuales == 2&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 57;
                isFriendo = true;
                friendo4 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
            }
            else if(timerReal.segundosActuales == 1&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 56;
                isFriendo = true;
                friendo5 = true;
                comidaAleatoria.comida.SetActive(false);
                
                
            
            }else if(timerReal.segundosActuales == 0&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 55;
                isFriendo = true;
                friendo6 = true;
                comidaAleatoria.comida.SetActive(false);
            }
        }
        if(friendo1== true && tiempoFreir == timerReal.segundosActuales)
        {
            isFriendo = false;
            friendo1 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 8)
            {
                comidaAleatoria.comida.layer = 18;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 22;
            }
            else if(comidaAleatoria.comida.layer ==26)
            {
                comidaAleatoria.comida.layer =19;
            }
        }
        else if(friendo2 == true && tiempoFreir == timerReal.segundosActuales)
        {
            isFriendo = false;
            friendo2 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 8)
            {
                comidaAleatoria.comida.layer = 18;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 22;
            }
            else if(comidaAleatoria.comida.layer ==26)
            {
                comidaAleatoria.comida.layer =19;
            }
        }
        else if(friendo3 == true && tiempoFreir == timerReal.segundosActuales)
        {
            isFriendo = false;
            friendo3 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 8)
            {
                comidaAleatoria.comida.layer = 18;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 22;
            }
            else if(comidaAleatoria.comida.layer ==26)
            {
                comidaAleatoria.comida.layer =19;
            }
        }
        else if(friendo4 == true && tiempoFreir == timerReal.segundosActuales)
        {
            isFriendo = false;
            friendo4 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 8)
            {
                comidaAleatoria.comida.layer = 18;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 22;
            }
            else if(comidaAleatoria.comida.layer ==26)
            {
                comidaAleatoria.comida.layer =19;
            }
        }
        else if(friendo5 == true && tiempoFreir == timerReal.segundosActuales)
        {
            isFriendo = false;
            friendo5 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 8)
            {
                comidaAleatoria.comida.layer = 18;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 22;
            }
            else if(comidaAleatoria.comida.layer ==26)
            {
                comidaAleatoria.comida.layer =19;
            }
        }
        else if(friendo6 == true && tiempoFreir == timerReal.segundosActuales)
        {
            isFriendo = false;
            friendo6 =false;
            comidaAleatoria.comida.SetActive(true);
            if(comidaAleatoria.comida.layer== 8)
            {
                comidaAleatoria.comida.layer = 18;
            }
            else if(comidaAleatoria.comida.layer == 6)
            {
                comidaAleatoria.comida.layer = 22;
            }
            else if(comidaAleatoria.comida.layer ==26)
            {
                comidaAleatoria.comida.layer =19;
            }
        }

    }
    private void Awake() 
    {
        comidaAleatoria = FindObjectOfType<ComodiaAleatoria>();
    }
    
}
