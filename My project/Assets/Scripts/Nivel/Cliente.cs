using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    public int valorRandom1;
    public int valorRandom2;
    public int valorRandom3;
    public int valorRandom4;
    public int valorRandom5;
    public int valorRandom6;
    public GameObject[] ComidasCanvas;
    public System.Random random = new System.Random();
    public TimerReal timerReal;
    public int valorActual;

    private void Start()
    {
        
      

        valorRandom1 = random.Next(0,ComidasCanvas.Length);
        valorRandom2 = random.Next(0,ComidasCanvas.Length);
        valorRandom3 = random.Next(0,ComidasCanvas.Length);
        valorRandom4 = random.Next(0,ComidasCanvas.Length);
        valorRandom5 = random.Next(0,ComidasCanvas.Length);
        valorRandom6 = random.Next(0,ComidasCanvas.Length);
    }
    private void Update() 
    {

       
       
        if(timerReal.segundosActuales  == 59 && timerReal.minutosActuales == 2)
        {
            
            
            print("hola");
            ComidasCanvas[valorRandom1].SetActive(true);
            print(valorActual);
        }
        if(timerReal.segundosActuales  == 30 && timerReal.minutosActuales == 2 )
        {
            print("hola1");
            ComidasCanvas[valorRandom1].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);
            ComidasCanvas[valorRandom2].SetActive(true);
        }
        if(timerReal.segundosActuales == 59&& timerReal.minutosActuales == 1 )
        {
            print("hola2");
            ComidasCanvas[valorRandom2].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorRandom3].SetActive(true);

        }
        if(timerReal.segundosActuales == 30 && timerReal.minutosActuales == 1 )
        {
            
            print("hola3");
            ComidasCanvas[valorRandom3].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorRandom4].SetActive(true);
        }
        if(timerReal.segundosActuales == 59 && timerReal.minutosActuales == 0 )
        {
              
            print("hola4");
            ComidasCanvas[valorRandom4].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorRandom5].SetActive(true);
        }
        if(timerReal.segundosActuales == 30 && timerReal.minutosActuales ==0 )
        {
            
            print("hola5");
            ComidasCanvas[valorRandom5].SetActive(false);
            ComidasCanvas[valorRandom6].SetActive(true);

        }
        if(timerReal.segundosActuales == 1 && timerReal.minutosActuales ==0 )
        {
            ComidasCanvas[valorRandom6].SetActive(false);
        }



       
    }   
}
