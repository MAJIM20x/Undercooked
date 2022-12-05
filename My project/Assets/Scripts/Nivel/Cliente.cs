using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    private int valorRandom1;
    private int valorRandom2;
    private int valorRandom3;
    private int valorRandom4;
    private int valorRandom5;
    private int valorRandom6;
    public GameObject[] ComidasCanvas;
    public GameObject[] Ensalada;
    public GameObject[] Hamburguesa;
    public GameObject[] PapasFritas;
    public GameObject[] Pollito;
    public GameObject[] Sushi;
    public System.Random random = new System.Random();
    public List<GameObject[]> listaComidas;
    public TimerReal timerReal;
    public int valorActual;

    private void Start()
    {
        this.listaComidas = new List<GameObject[]>();
        listaComidas.Add(Ensalada);
        listaComidas.Add(Hamburguesa);
        listaComidas.Add(PapasFritas);
        listaComidas.Add(Pollito);
        listaComidas.Add(Sushi);

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
        if(timerReal.segundosActuales  == 24 && timerReal.minutosActuales == 2 )
        {
            print("hola1");
            ComidasCanvas[valorRandom1].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);
            ComidasCanvas[valorRandom2].SetActive(true);
        }
        if(timerReal.segundosActuales == 48 && timerReal.minutosActuales == 1 )
        {
            print("hola2");
            ComidasCanvas[valorRandom2].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorRandom3].SetActive(true);

        }
        if(timerReal.segundosActuales == 12 && timerReal.minutosActuales == 1 )
        {
            
            print("hola3");
            ComidasCanvas[valorRandom3].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorRandom4].SetActive(true);
        }
        if(timerReal.segundosActuales == 36 && timerReal.minutosActuales == 0 )
        {
              
            print("hola4");
            ComidasCanvas[valorRandom4].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorRandom5].SetActive(true);
        }
        if(timerReal.segundosActuales == 0 && timerReal.minutosActuales ==0 )
        {
            
            print("hola5");
            ComidasCanvas[valorRandom5].SetActive(false);
        }



       
    }   
}
