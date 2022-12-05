using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComodiaAleatoria : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    public Rigidbody2D jugador;
    public Transform posicionGeneradorComida;
    public GameObject[] prefab;
    public GameObject[] prefabCanvas;
    public int contador = 0;
    public GameObject comida;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            isInside= true;
            print("HOLAmUNDO");
            
        }
        
    }
    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isInside = false;
            print("cHAOmUNDO");
        }
    }
    private void Update() {
        if(isInside== true)
        {
        prefabCanvas[contador].SetActive(true);
                if(Input.GetKeyDown(KeyCode.Q))
                {
                    prefabCanvas[contador].SetActive(false);
                    contador++;
                    if(contador ==prefabCanvas.Length)
                    {
                        contador = 0;
                    }
                    
                    
                }
                if(Input.GetKeyDown(KeyCode.P))
                {
                    comida = Instantiate(prefab[contador],new Vector3(posicionGeneradorComida.position.x,posicionGeneradorComida.position.y,0),Quaternion.identity);
                    comida.SetActive(true);
                    comida.tag = "Items";
                    if(contador == 0)
                    {
                        comida.layer = 12;
                    }
                    else if(contador == 1)
                    {
                        comida.layer = 8;
                    }
                    else if(contador == 2)
                    {
                        comida.layer = 7; 
                    }
                    else if(contador == 3)
                    {
                        comida.layer =3;
                    }
                    else if(contador == 4)
                    {
                        comida.layer = 9;
                    }
                    else if(contador == 5)
                    {
                        comida.layer =10;
                    }
                    else if (contador == 6)
                    {
                        comida.layer = 11;
                    }
                    else if(contador == 7)
                    {
                        comida.layer = 6;
                    }
                    else if(contador == 8)
                    {
                        comida.layer = 25;
                    }
                    

                }
        }
        else
        {
            prefabCanvas[contador].SetActive(false);
        }
                
    }
    
    

}
