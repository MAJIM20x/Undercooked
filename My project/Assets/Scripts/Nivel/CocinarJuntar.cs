using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocinarJuntar : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    private ComodiaAleatoria[] comidasAleatorias;
    public TimerReal timerReal;
    private GameObject vacio;
    private int tiempoHervir;   
    public Rigidbody2D rb;
    public GameObject spawner;
    public GameObject[] prefrabs;
    public Transform posicion;


   
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

    private void FoodVerifier(ComodiaAleatoria[] comidas, int layer1, int layer2, int layer3, int prefabIndex,int newFoodLayer)
    {
        List<int> foodList = new List<int>();
        foodList.Add(layer1);
        foodList.Add(layer2);
        foodList.Add(layer3);
        foreach(var comodia in comidas)
        {
            if(foodList.Contains(comodia.comida.layer))
            {
                foodList.Remove(comodia.comida.layer);
            }
        }
        if(foodList.Count == 0) DestroyFood(comidas);
        spawner = Instantiate(prefrabs[prefabIndex], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
        spawner.layer = newFoodLayer;
    }

    private void DestroyFood(ComodiaAleatoria[] comidas)
    {
        foreach(var comodia in comidas)
        {
            Destroy(comodia.gameObject);
        }
    }

    


    private void Update() 
    {
        if(transform.childCount != 6)
        {
            return;
        }
        comidasAleatorias = GetComponentsInChildren<ComodiaAleatoria>();

        /* 
        
        // ensalada
            if(comidaAleatoria.comida.layer ==8)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 21)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 14)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[0], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =24;
            //hamurguesa

            if(comidaAleatoria.comida.layer ==9)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 16)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 8)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[1], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =25;
            }
            //PolloFrito

            else if(comidaAleatoria.comida.layer == 22 && comidaAleatoria.comida.layer == 22 & comidaAleatoria.comida.layer == 19)
            {
            if(comidaAleatoria.comida.layer ==22)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 22)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 19)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[2], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =26;
            }
            //PapasFritas

            else if(comidaAleatoria.comida.layer == 19 && comidaAleatoria.comida.layer == 19&& comidaAleatoria.comida.layer == 19)
            {
            if(comidaAleatoria.comida.layer ==19)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 19)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 19)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[3], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =27;
            }
            //Sushi
            else if(comidaAleatoria.comida.layer == 23 &&comidaAleatoria.comida.layer == 20 &&comidaAleatoria.comida.layer == 3)
            {
            if(comidaAleatoria.comida.layer ==23)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 20)
            {
                Destroy(comidaAleatoria.comida);
            }
            else if(comidaAleatoria.comida.layer == 3)
            {
                Destroy(comidaAleatoria.comida);
            }
            spawner = Instantiate(prefrabs[4], new Vector3(posicion.position.x, posicion.position.y,0),Quaternion.identity);
            spawner.layer =28;
            }
        
        }


        */
    }
    
    
}
