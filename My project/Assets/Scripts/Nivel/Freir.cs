using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freir : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria ComidaAleatoria;
    private TimerReal timerReal;
    private int tiempoFreir;
    
    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6 ||ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 10 ||ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 8 )
        {
            
            isInside= true;
            print("HOLAmUNDO");
            
        }
        
    }
    //Metodo que verifica si ya salio de la zona
    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player") && other.gameObject.CompareTag("Plato"))
        {
            isInside = false;
            print("cHAOmUNDO");
        }
    }
    private void Update() {
        if(isInside == true)
        {
            if(timerReal.segundosActuales > 5 && timerReal.minutosActuales >= 0)
            {
                tiempoFreir = timerReal.segundosActuales -5; 
            }
            else if(timerReal.segundosActuales == 4&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 59;

            }else if(timerReal.segundosActuales == 3&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 58;
            }else if(timerReal.segundosActuales == 2&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 57;
            }else if(timerReal.segundosActuales == 1&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 56;
            
            }else if(timerReal.segundosActuales == 0&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 55;
            }
            
        }
    }
}
