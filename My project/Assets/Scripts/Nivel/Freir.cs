using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freir : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria ComidaAleatoria;
    public TimerReal timerReal;
    private GameObject vacio;
    private int tiempoFreir;
    public Rigidbody2D rb;
    public PolloScripts pollo;
    public PapaScripts papa;
    public CarneScripts carne;
    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") )
        {
            
            isInside= true;
            print("HOLAmUNDO");
            
        }
        
    }
    //Metodo que verifica si ya salio de la zona
    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isInside = false;
            print("cHAOmUNDO");
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
                pollo.desaparecer();
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        print("Arreglao");
                        ;
                        if(ComidaAleatoria.comida.layer == 6)
                        {
                            ComidaAleatoria.comida.layer = 22;
                        }
                        else if(ComidaAleatoria.comida.layer ==8)
                        {
                            ComidaAleatoria.comida.layer = 18;
                            break;
                        }
                        else if(ComidaAleatoria.comida.layer == 25)
                        {
                            ComidaAleatoria.comida.layer=19;
                            break;
                        }
                        

                    }
                }
                
            }
            else if(timerReal.segundosActuales == 4&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 59;
                ComidaAleatoria.comida.SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        ComidaAleatoria.comida.SetActive(true);
                        if(ComidaAleatoria.comida.layer == 6)
                        {
                            ComidaAleatoria.comida.layer = 22;
                        }
                        else if(ComidaAleatoria.comida.layer ==8)
                        {
                            ComidaAleatoria.comida.layer = 18;
                        }
                        else if(ComidaAleatoria.comida.layer == 25)
                        {
                            ComidaAleatoria.comida.layer=19;
                        }
                        break;

                    }
                }

            }else if(timerReal.segundosActuales == 3&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 58;
                ComidaAleatoria.comida.SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        ComidaAleatoria.comida.SetActive(true);
                        if(ComidaAleatoria.comida.layer == 6)
                        {
                            ComidaAleatoria.comida.layer = 22;
                        }
                        else if(ComidaAleatoria.comida.layer ==8)
                        {
                            ComidaAleatoria.comida.layer = 18;
                        }
                        else if(ComidaAleatoria.comida.layer == 25)
                        {
                            ComidaAleatoria.comida.layer=19;
                        }
                        break;

                    }
                }
            }else if(timerReal.segundosActuales == 2&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 57;
                ComidaAleatoria.comida.SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        ComidaAleatoria.comida.SetActive(true);
                        if(ComidaAleatoria.comida.layer == 6)
                        {
                            ComidaAleatoria.comida.layer = 22;
                        }
                        else if(ComidaAleatoria.comida.layer ==8)
                        {
                            ComidaAleatoria.comida.layer = 18;
                        }
                        else if(ComidaAleatoria.comida.layer == 25)
                        {
                            ComidaAleatoria.comida.layer=19;
                        }
                        break;

                    }
                }
            }else if(timerReal.segundosActuales == 1&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 56;
                ComidaAleatoria.comida.SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        ComidaAleatoria.comida.SetActive(true);
                        if(ComidaAleatoria.comida.layer == 6)
                        {
                            ComidaAleatoria.comida.layer = 22;
                        }
                        else if(ComidaAleatoria.comida.layer ==8)
                        {
                            ComidaAleatoria.comida.layer = 18;
                        }
                        else if(ComidaAleatoria.comida.layer == 25)
                        {
                            ComidaAleatoria.comida.layer=19;
                        }
                        break;

                    }
                }
            
            }else if(timerReal.segundosActuales == 0&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 55;
                ComidaAleatoria.comida.SetActive(false);
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        ComidaAleatoria.comida.SetActive(true);
                        if(ComidaAleatoria.comida.layer == 6)
                        {
                            ComidaAleatoria.comida.layer = 22;
                            break;
                        }
                        else if(ComidaAleatoria.comida.layer ==8)
                        {
                            ComidaAleatoria.comida.layer = 18;
                            break;
                        }
                        else if(ComidaAleatoria.comida.layer == 25)
                        {
                            ComidaAleatoria.comida.layer=19;
                            break;
                        }
                        

                    }
                }
           
            
            }
        }
    }
}
