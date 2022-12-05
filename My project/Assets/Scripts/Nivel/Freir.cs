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
    private GameObject polloGuardado;
    private GameObject carneGuardado;
    private GameObject papaGuardado;    
    public Rigidbody2D rb;
    public Rigidbody2D polloRb;
    public Rigidbody2D carneRb;
    public Rigidbody2D papaRb;
    public PolloScripts pollo;
    public PapaScripts papa;
    public CarneScripts carne;


    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")  )
        {
            if(other.gameObject.layer== 6)
            {
                polloGuardado = other.gameObject;
            }
            else if(other.gameObject.layer == 8)
            {
                print("holauwu");
                carneGuardado = other.gameObject;
            }
            else if(other.gameObject.layer == 26)
            {
                papaGuardado = other.gameObject;
            }
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
                if(polloGuardado !=null)
                {
                    pollo.desaparecer();
                }
                else if(carneGuardado != null)
                {
                    print("holauwu");
                    carne.desaparecer();
                }
                else if(papaGuardado != null)
                {
                    papa.desaparecer();
                }
                /*while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        if(polloGuardado !=null)
                        {
                            print("Arreglao");
                            pollo.aparecer();
                            if(ComidaAleatoria.comida.layer == 6)
                            {
                                ComidaAleatoria.comida.layer = 22;
                            }
                        }
                        else if(carneGuardado != null)
                        {
                            carne.aparecer();
                            if(ComidaAleatoria.comida.layer ==8)
                            {
                                ComidaAleatoria.comida.layer = 18;
                                break;
                            }
                        }
                        else if(papaGuardado !=null)
                        {
                            if(ComidaAleatoria.comida.layer == 25)
                            {
                                ComidaAleatoria.comida.layer=19;
                                break;
                            }
                        }
                    }
                }*/
                
            }
            else if(timerReal.segundosActuales == 4&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 59;
                if(polloGuardado !=null)
                {
                    pollo.desaparecer();
                }
                else if(carneGuardado != null)
                {
                    carne.desaparecer();
                }
                else if(papaGuardado != null)
                {
                    papa.desaparecer();
                }
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        if(polloGuardado !=null)
                        {
                            print("Arreglao");
                            pollo.aparecer();
                            if(ComidaAleatoria.comida.layer == 6)
                            {
                                ComidaAleatoria.comida.layer = 22;
                            }
                        }
                        else if(carneGuardado != null)
                        {
                            carne.aparecer();
                            if(ComidaAleatoria.comida.layer ==8)
                            {
                                ComidaAleatoria.comida.layer = 18;
                                break;
                            }
                        }
                        else if(papaGuardado !=null)
                        {
                            if(ComidaAleatoria.comida.layer == 25)
                            {
                                ComidaAleatoria.comida.layer=19;
                                break;
                            }
                        }
                    }
                }

            }else if(timerReal.segundosActuales == 3&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 58;
                if(polloGuardado !=null)
                {
                    pollo.desaparecer();
                }
                else if(carneGuardado != null)
                {
                    carne.desaparecer();
                }
                else if(papaGuardado != null)
                {
                    papa.desaparecer();
                }
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        if(polloGuardado !=null)
                        {
                            print("Arreglao");
                            pollo.aparecer();
                            if(ComidaAleatoria.comida.layer == 6)
                            {
                                ComidaAleatoria.comida.layer = 22;
                            }
                        }
                        else if(carneGuardado != null)
                        {
                            carne.aparecer();
                            if(ComidaAleatoria.comida.layer ==8)
                            {
                                ComidaAleatoria.comida.layer = 18;
                                break;
                            }
                        }
                        else if(papaGuardado !=null)
                        {
                            if(ComidaAleatoria.comida.layer == 25)
                            {
                                ComidaAleatoria.comida.layer=19;
                                break;
                            }
                        }
                    }
                }
            }else if(timerReal.segundosActuales == 2&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 57;
                if(polloGuardado !=null)
                {
                    pollo.desaparecer();
                }
                else if(carneGuardado != null)
                {
                    carne.desaparecer();
                }
                else if(papaGuardado != null)
                {
                    papa.desaparecer();
                }
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        if(polloGuardado !=null)
                        {
                            print("Arreglao");
                            pollo.aparecer();
                            if(ComidaAleatoria.comida.layer == 6)
                            {
                                ComidaAleatoria.comida.layer = 22;
                            }
                        }
                        else if(carneGuardado != null)
                        {
                            carne.aparecer();
                            if(ComidaAleatoria.comida.layer ==8)
                            {
                                ComidaAleatoria.comida.layer = 18;
                                break;
                            }
                        }
                        else if(papaGuardado !=null)
                        {
                            if(ComidaAleatoria.comida.layer == 25)
                            {
                                ComidaAleatoria.comida.layer=19;
                                break;
                            }
                        }
                    }
                }
            }
            else if(timerReal.segundosActuales == 1&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 56;
                if(polloGuardado !=null)
                {
                    pollo.desaparecer();
                }
                else if(carneGuardado != null)
                {
                    carne.desaparecer();
                }
                else if(papaGuardado != null)
                {
                    papa.desaparecer();
                }
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        if(polloGuardado !=null)
                        {
                            print("Arreglao");
                            pollo.aparecer();
                            if(ComidaAleatoria.comida.layer == 6)
                            {
                                ComidaAleatoria.comida.layer = 22;
                            }
                        }
                        else if(carneGuardado != null)
                        {
                            carne.aparecer();
                            if(ComidaAleatoria.comida.layer ==8)
                            {
                                ComidaAleatoria.comida.layer = 18;
                                break;
                            }
                        }
                        else if(papaGuardado !=null)
                        {
                            if(ComidaAleatoria.comida.layer == 25)
                            {
                                ComidaAleatoria.comida.layer=19;
                                break;
                            }
                        }
                    }
                }
            
            }else if(timerReal.segundosActuales == 0&& timerReal.minutosActuales >0)
            {
                tiempoFreir = 55;
                if(polloGuardado !=null)
                {
                    pollo.desaparecer();
                }
                else if(carneGuardado != null)
                {
                    carne.desaparecer();
                }
                else if(papaGuardado != null)
                {
                    papa.desaparecer();
                }
                while(true)
                {
                    if(timerReal.segundosActuales == tiempoFreir)
                    {
                        if(polloGuardado !=null)
                        {
                            print("Arreglao");
                            pollo.aparecer();
                            if(ComidaAleatoria.comida.layer == 6)
                            {
                                ComidaAleatoria.comida.layer = 22;
                            }
                        }
                        else if(carneGuardado != null)
                        {
                            carne.aparecer();
                            if(ComidaAleatoria.comida.layer ==8)
                            {
                                ComidaAleatoria.comida.layer = 18;
                                break;
                            }
                        }
                        else if(papaGuardado !=null)
                        {
                            if(ComidaAleatoria.comida.layer == 25)
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
}
