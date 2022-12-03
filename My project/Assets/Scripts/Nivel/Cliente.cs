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
        int numeroRandom1 = random.Next(0, ComidasCanvas.Length);
        int numeroRandomGuardado1= numeroRandom1;
        int numeroRandom2 = random.Next(0, ComidasCanvas.Length);
        int numeroRandom3 = random.Next(0, ComidasCanvas.Length);
        int numeroRandom4 = random.Next(0, ComidasCanvas.Length);
        int numeroRandom5 = random.Next(0, ComidasCanvas.Length);
        int numeroRandomGuardado2= numeroRandom2;
        int numeroRandomGuardado3= numeroRandom3;
        int numeroRandomGuardado4= numeroRandom4;
        int numeroRandomGuardado5= numeroRandom5;
       
        if(timerReal.segundosActuales == 0 && timerReal.minutosActuales == 3)
        {
            print("hola");
            ComidasCanvas[numeroRandomGuardado1].SetActive(true);
        }
        if(timerReal.segundosActuales  ==24  && timerReal.minutosActuales == 2)
        {
            print("hola");
            ComidasCanvas[numeroRandomGuardado1].SetActive(false);
            ComidasCanvas[numeroRandomGuardado2].SetActive(true);
        }
        if(timerReal.segundosActuales == 48 && timerReal.minutosActuales == 1)
        {
            print("hola");
            ComidasCanvas[numeroRandomGuardado2].SetActive(false);
            ComidasCanvas[numeroRandomGuardado3].SetActive(true);

        }if(timerReal.segundosActuales == 12 && timerReal.minutosActuales == 1)
        {
            print("hola");
            ComidasCanvas[numeroRandomGuardado3].SetActive(false);
            ComidasCanvas[numeroRandomGuardado4].SetActive(true);
        }if(timerReal.segundosActuales == 36 && timerReal.minutosActuales == 0)
        {   
            print("hola");
            ComidasCanvas[numeroRandomGuardado4].SetActive(false);
            ComidasCanvas[numeroRandomGuardado5].SetActive(true);
        }if(timerReal.segundosActuales == 0 && timerReal.minutosActuales ==0)
        {
            print("hola");
            ComidasCanvas[numeroRandomGuardado5].SetActive(false);
        }



       
    }   
}
