using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocinarJuntar : MonoBehaviour
{
    private bool isInside = false;
    private ComodiaAleatoria ComidaAleatoria;
    private GameObject prefabEnsalada;
    private GameObject prefabSushi;
    private GameObject prefabHamburguesa;
    private GameObject prefabPollito;
    private GameObject prefabPapasFritasListo;
    private TimerReal timerReal;
    private int tiempoHervir;
    public Rigidbody2D rb;
    private GameObject objetoARecojer;
    [SerializeField] private Transform posicionGenerador;
    private void OnTriggerEnter2D(Collider2D other) {
    
        if(other.gameObject.CompareTag("Player") )
        {
            isInside= true;
            print("HOLAmUNDO");
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isInside= false;
            print("ChaoMundo");
        }    
    }
    private void Update() 
    {
        if(isInside)
        {
            if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 7 &&ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 23 && ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 21)
            {
                objetoARecojer =Instantiate(prefabEnsalada,new Vector3(posicionGenerador.position.x, posicionGenerador.position.y,0),Quaternion.identity);
                objetoARecojer.layer= 13;
            }
            else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 7 &&ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 7 && ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 7 )
            {
                objetoARecojer =  Instantiate(prefabPapasFritasListo, new Vector3(posicionGenerador.position.x, posicionGenerador.position.y,0),Quaternion.identity);
                objetoARecojer.layer = 15;
            }
            else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer ==20 && ComidaAleatoria.prefab[ComidaAleatoria.contador].layer ==3 &&ComidaAleatoria.prefab[ComidaAleatoria.contador].layer ==24)
            {
                objetoARecojer = Instantiate(prefabSushi, new Vector3(posicionGenerador.position.x, posicionGenerador.position.y,0),Quaternion.identity);
                objetoARecojer.layer =17;
            }
            else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 22&& ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 22 && ComidaAleatoria.prefab[ComidaAleatoria.contador].layer == 19)
            {
                objetoARecojer = Instantiate(prefabPollito, new Vector3(posicionGenerador.position.x,posicionGenerador.position.y,0),Quaternion.identity);
                objetoARecojer.layer = 16;

            }
            else if(ComidaAleatoria.prefab[ComidaAleatoria.contador].layer ==9 &&ComidaAleatoria.prefab[ComidaAleatoria.contador].layer ==7 &&ComidaAleatoria.prefab[ComidaAleatoria.contador].layer ==18)
            {
                objetoARecojer = Instantiate(prefabHamburguesa, new Vector3(posicionGenerador.position.x, posicionGenerador.position.y,0),Quaternion.identity);
                objetoARecojer.layer = 14;
            }

        }
    }
}
