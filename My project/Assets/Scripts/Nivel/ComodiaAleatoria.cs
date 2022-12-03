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
        prefabCanvas[contador].SetActive(true);
         if(Input.GetKeyDown(KeyCode.Q))
        {
            prefabCanvas[contador].SetActive(false);
            contador++;
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            comida = Instantiate(prefab[contador],new Vector3(posicionGeneradorComida.position.x,posicionGeneradorComida.position.y,0),Quaternion.identity);
            comida.tag = "Comida";
            comida.layer = contador;

        }
    }
    

}
