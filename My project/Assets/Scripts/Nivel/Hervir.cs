using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hervir : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria ComidaAleatoria;
    private TimerReal timerReal;
    private int tiempoHervir;
    public Rigidbody2D rb;
    
    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6 ||ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 12  )
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
                
                tiempoHervir = timerReal.segundosActuales -5; 
                ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoHervir)
                    {
                        ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(true);
                        if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer = 21;
                        }
                        
                        else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 12)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer=20;
                        }

                    }
                }
                
            }
            else if(timerReal.segundosActuales == 4&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 59;
                ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoHervir)
                    {
                        ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(true);
                        if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer = 21;
                        }
                        else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 12)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer=20;
                        }

                    }
                }

            }else if(timerReal.segundosActuales == 3&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 511;
                ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoHervir)
                    {
                        ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(true);
                        if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer = 21;
                        }
                        else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 12)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer=20;
                        }

                    }
                }
            }else if(timerReal.segundosActuales == 2&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 57;
                ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoHervir)
                    {
                        ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(true);
                        if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer = 21;
                        }
                        else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 12)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer=20;
                        }

                    }
                }
            }else if(timerReal.segundosActuales == 1&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 56;
                ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoHervir)
                    {
                        ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(true);
                        if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer = 21;
                        }
                        else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 12)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer=20;
                        }

                    }
                }
            
            }else if(timerReal.segundosActuales == 0&& timerReal.minutosActuales >0)
            {
                tiempoHervir = 55;
                ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoHervir)
                    {
                        ComidaAleatoria.prefab[ComidaAleatoria.contador].SetActive(true);
                        if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 6)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer = 21;
                        }
                        else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 12)
                        {
                            ComidaAleatoria.prefab[ComidaAleatoria.contador].layer=20;
                        }

                    }
                }
           
            
            }
        }
    }
}
