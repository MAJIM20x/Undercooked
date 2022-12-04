using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    public GameObject[] ComidasCanvas;
    public GameObject[] Ensalada;
    public GameObject[] Hamburguesa;
    public GameObject[] PapasFritas;
    public GameObject[] Pollito;
    public GameObject[] Sushi;
    public System.Random random = new System.Random();
    private List<GameObject[]> listaComidas;
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
    }
    private void Update() 
    {

       
       
        if(timerReal.segundosActuales  == 59 && timerReal.minutosActuales == 2 && ComidasCanvas[valorActual].activeInHierarchy == false )
        {
            ComidasCanvas[valorActual].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);
            print("hola");
            ComidasCanvas[valorActual].SetActive(true);
            print(valorActual);
        }
        if(timerReal.segundosActuales  == 24 && timerReal.minutosActuales == 2 && ComidasCanvas[valorActual].activeInHierarchy == false)
        {
            print("hola1");
            ComidasCanvas[valorActual].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);
            ComidasCanvas[valorActual].SetActive(true);
        }
        if(timerReal.segundosActuales == 48 && timerReal.minutosActuales == 1 && ComidasCanvas[valorActual].activeInHierarchy == false)
        {
            print("hola2");
            ComidasCanvas[valorActual].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorActual].SetActive(true);

        }
        if(timerReal.segundosActuales == 12 && timerReal.minutosActuales == 1 &&ComidasCanvas[valorActual].activeInHierarchy == false)
        {
            
            print("hola3");
            ComidasCanvas[valorActual].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorActual].SetActive(true);
        }
        if(timerReal.segundosActuales == 36 && timerReal.minutosActuales == 0 && ComidasCanvas[valorActual].activeInHierarchy == false)
        {
              
            print("hola4");
            ComidasCanvas[valorActual].SetActive(false);
            valorActual = random.Next(0, ComidasCanvas.Length);

            ComidasCanvas[valorActual].SetActive(true);
        }
        if(timerReal.segundosActuales == 0 && timerReal.minutosActuales ==0 && ComidasCanvas[valorActual].activeInHierarchy == false)
        {
            
            print("hola5");
            ComidasCanvas[valorActual].SetActive(false);
        }



       
    }   
}
