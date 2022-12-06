using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregaDePlato : MonoBehaviour
{
    [SerializeField] private bool isInside = false;
    public Transform[] posicionPlato;
    public Rigidbody2D mueble;
    public PlayerInputActions playerInputActions;
    public Cliente cliente;
    public GeneradorDePlatos generadorDePlatos;
    public CocinarJuntar juntar;
    public TimerReal tiempo;
    public int puntos;

    //Metodo que verifica si esta en la zona 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player1"))
        {
            
            isInside= true;
            print("HOLAmUNDO");
            
        }
        
    }
    //Metodo que verifica si ya salio de la zona
    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player1") )
        {
            isInside = false;
            print("cHAOmUNDO");
        }
    }
    // update
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && isInside)
            {
                
                if(cliente.ComidasCanvas[cliente.valorRandom1].layer == juntar.spawner.layer)
                {
                    if(tiempo.segundosActuales == 59)
                    {
                        puntos += 70;
                    }
                    else if(tiempo.segundosActuales == 58)
                    {
                        puntos += 65;
                    }else if(tiempo.segundosActuales == 57)
                    {
                        puntos += 60;
                    }else if(tiempo.segundosActuales == 56)
                    {
                        puntos += 55;
                    }else if(tiempo.segundosActuales == 55)
                    {
                        puntos += 50;
                    }else if(tiempo.segundosActuales == 54)
                    {
                        puntos += 49;
                    }else if(tiempo.segundosActuales == 53)
                    {
                        puntos += 48;
                    }else if(tiempo.segundosActuales == 52)
                    {
                        puntos += 47;
                    }else if(tiempo.segundosActuales == 51)
                    {
                        puntos += 46;
                    }
                    else if(tiempo.segundosActuales == 50)
                    {
                        puntos += 40;                        
                    }
                    else if (tiempo.segundosActuales == 49)
                    {
                        puntos += 39;                        

                    }
                    else if (tiempo.segundosActuales == 48)
                    {
                        puntos += 38;
                    }
                    else if (tiempo.segundosActuales == 47)
                    {
                        puntos += 37;
                    }
                    else if (tiempo.segundosActuales == 46)
                    {
                        puntos += 36;
                    }
                    else if (tiempo.segundosActuales == 45)
                    {
                        puntos += 35;
                    }
                    else if (tiempo.segundosActuales == 44)
                    {
                        puntos += 34;
                    }
                    else if (tiempo.segundosActuales == 43)
                    {
                        puntos += 33;
                    }
                    else if (tiempo.segundosActuales == 42)
                    {
                        puntos += 32;
                    }
                    else if (tiempo.segundosActuales == 41)
                    {
                        puntos += 31;
                    }
                    else if (tiempo.segundosActuales == 40)
                    {
                        puntos += 30;
                    }
                    else if (tiempo.segundosActuales == 39)
                    {
                        puntos += 29;
                    }
                    else if (tiempo.segundosActuales == 38)
                    {
                        puntos += 28;
                    }else if (tiempo.segundosActuales == 37)
                    {
                        puntos += 27;
                    }else if (tiempo.segundosActuales == 36)
                    {
                        puntos += 26;
                    }else if (tiempo.segundosActuales == 35)
                    {
                        puntos += 25;
                    }else if (tiempo.segundosActuales == 34)
                    {
                        puntos += 24;
                    }else if (tiempo.segundosActuales == 33)
                    {
                        puntos += 23;
                    }else if (tiempo.segundosActuales == 32)
                    {
                        puntos += 22;
                    }else if (tiempo.segundosActuales == 31)
                    {
                        puntos += 1;
                    }
                
                }
                else if(cliente.ComidasCanvas[cliente.valorRandom2].layer == juntar.spawner.layer)
                {
                    if(tiempo.segundosActuales == 29)
                    {
                        puntos += 70;
                    }
                    else if(tiempo.segundosActuales == 28)
                    {
                        puntos += 65;
                    }else if(tiempo.segundosActuales == 27)
                    {
                        puntos += 60;
                    }else if(tiempo.segundosActuales == 26)
                    {
                        puntos += 55;
                    }else if(tiempo.segundosActuales == 25)
                    {
                        puntos += 50;
                    }else if(tiempo.segundosActuales == 24)
                    {
                        puntos += 49;
                    }else if(tiempo.segundosActuales == 23)
                    {
                        puntos += 48;
                    }else if(tiempo.segundosActuales == 22)
                    {
                        puntos += 47;
                    }else if(tiempo.segundosActuales == 21)
                    {
                        puntos += 46;
                    }
                    else if(tiempo.segundosActuales == 20)
                    {
                        puntos += 40;                        
                    }
                    else if (tiempo.segundosActuales == 19)
                    {
                        puntos += 39;                        

                    }
                    else if (tiempo.segundosActuales == 18)
                    {
                        puntos += 38;
                    }
                    else if (tiempo.segundosActuales == 17)
                    {
                        puntos += 37;
                    }
                    else if (tiempo.segundosActuales == 16)
                    {
                        puntos += 36;
                    }
                    else if (tiempo.segundosActuales == 15)
                    {
                        puntos += 35;
                    }
                    else if (tiempo.segundosActuales == 14)
                    {
                        puntos += 34;
                    }
                    else if (tiempo.segundosActuales == 13)
                    {
                        puntos += 33;
                    }
                    else if (tiempo.segundosActuales == 12)
                    {
                        puntos += 32;
                    }
                    else if (tiempo.segundosActuales == 11)
                    {
                        puntos += 31;
                    }
                    else if (tiempo.segundosActuales == 10)
                    {
                        puntos += 30;
                    }
                    else if (tiempo.segundosActuales == 9)
                    {
                        puntos += 29;
                    }
                    else if (tiempo.segundosActuales == 8)
                    {
                        puntos += 28;
                    }else if (tiempo.segundosActuales == 7)
                    {
                        puntos += 27;
                    }else if (tiempo.segundosActuales == 6)
                    {
                        puntos += 26;
                    }else if (tiempo.segundosActuales == 5)
                    {
                        puntos += 25;
                    }else if (tiempo.segundosActuales == 4)
                    {
                        puntos += 24;
                    }else if (tiempo.segundosActuales == 3)
                    {
                        puntos += 23;
                    }else if (tiempo.segundosActuales == 2)
                    {
                        puntos += 22;
                    }else if (tiempo.segundosActuales == 1)
                    {
                        puntos += 1;
                    }
                
                }
                else if(cliente.ComidasCanvas[cliente.valorRandom3].layer == juntar.spawner.layer)
                {
                    if(tiempo.segundosActuales == 59)
                    {
                        puntos += 70;
                    }
                    else if(tiempo.segundosActuales == 58)
                    {
                        puntos += 65;
                    }else if(tiempo.segundosActuales == 57)
                    {
                        puntos += 60;
                    }else if(tiempo.segundosActuales == 56)
                    {
                        puntos += 55;
                    }else if(tiempo.segundosActuales == 55)
                    {
                        puntos += 50;
                    }else if(tiempo.segundosActuales == 54)
                    {
                        puntos += 49;
                    }else if(tiempo.segundosActuales == 53)
                    {
                        puntos += 48;
                    }else if(tiempo.segundosActuales == 52)
                    {
                        puntos += 47;
                    }else if(tiempo.segundosActuales == 51)
                    {
                        puntos += 46;
                    }
                    else if(tiempo.segundosActuales == 50)
                    {
                        puntos += 40;                        
                    }
                    else if (tiempo.segundosActuales == 49)
                    {
                        puntos += 39;                        

                    }
                    else if (tiempo.segundosActuales == 48)
                    {
                        puntos += 38;
                    }
                    else if (tiempo.segundosActuales == 47)
                    {
                        puntos += 37;
                    }
                    else if (tiempo.segundosActuales == 46)
                    {
                        puntos += 36;
                    }
                    else if (tiempo.segundosActuales == 45)
                    {
                        puntos += 35;
                    }
                    else if (tiempo.segundosActuales == 44)
                    {
                        puntos += 34;
                    }
                    else if (tiempo.segundosActuales == 43)
                    {
                        puntos += 33;
                    }
                    else if (tiempo.segundosActuales == 42)
                    {
                        puntos += 32;
                    }
                    else if (tiempo.segundosActuales == 41)
                    {
                        puntos += 31;
                    }
                    else if (tiempo.segundosActuales == 40)
                    {
                        puntos += 30;
                    }
                    else if (tiempo.segundosActuales == 39)
                    {
                        puntos += 29;
                    }
                    else if (tiempo.segundosActuales == 38)
                    {
                        puntos += 28;
                    }else if (tiempo.segundosActuales == 37)
                    {
                        puntos += 27;
                    }else if (tiempo.segundosActuales == 36)
                    {
                        puntos += 26;
                    }else if (tiempo.segundosActuales == 35)
                    {
                        puntos += 25;
                    }else if (tiempo.segundosActuales == 34)
                    {
                        puntos += 24;
                    }else if (tiempo.segundosActuales == 33)
                    {
                        puntos += 23;
                    }else if (tiempo.segundosActuales == 32)
                    {
                        puntos += 22;
                    }else if (tiempo.segundosActuales == 31)
                    {
                        puntos += 1;
                    }
                
                }
                else if(cliente.ComidasCanvas[cliente.valorRandom4].layer == juntar.spawner.layer)
                {
                    if(tiempo.segundosActuales == 29)
                    {
                        puntos += 70;
                    }
                    else if(tiempo.segundosActuales == 28)
                    {
                        puntos += 65;
                    }else if(tiempo.segundosActuales == 27)
                    {
                        puntos += 60;
                    }else if(tiempo.segundosActuales == 26)
                    {
                        puntos += 55;
                    }else if(tiempo.segundosActuales == 25)
                    {
                        puntos += 50;
                    }else if(tiempo.segundosActuales == 24)
                    {
                        puntos += 49;
                    }else if(tiempo.segundosActuales == 23)
                    {
                        puntos += 48;
                    }else if(tiempo.segundosActuales == 22)
                    {
                        puntos += 47;
                    }else if(tiempo.segundosActuales == 21)
                    {
                        puntos += 46;
                    }
                    else if(tiempo.segundosActuales == 20)
                    {
                        puntos += 40;                        
                    }
                    else if (tiempo.segundosActuales == 19)
                    {
                        puntos += 39;                        

                    }
                    else if (tiempo.segundosActuales == 18)
                    {
                        puntos += 38;
                    }
                    else if (tiempo.segundosActuales == 17)
                    {
                        puntos += 37;
                    }
                    else if (tiempo.segundosActuales == 16)
                    {
                        puntos += 36;
                    }
                    else if (tiempo.segundosActuales == 15)
                    {
                        puntos += 35;
                    }
                    else if (tiempo.segundosActuales == 14)
                    {
                        puntos += 34;
                    }
                    else if (tiempo.segundosActuales == 13)
                    {
                        puntos += 33;
                    }
                    else if (tiempo.segundosActuales == 12)
                    {
                        puntos += 32;
                    }
                    else if (tiempo.segundosActuales == 11)
                    {
                        puntos += 31;
                    }
                    else if (tiempo.segundosActuales == 10)
                    {
                        puntos += 30;
                    }
                    else if (tiempo.segundosActuales == 9)
                    {
                        puntos += 29;
                    }
                    else if (tiempo.segundosActuales == 8)
                    {
                        puntos += 28;
                    }else if (tiempo.segundosActuales == 7)
                    {
                        puntos += 27;
                    }else if (tiempo.segundosActuales == 6)
                    {
                        puntos += 26;
                    }else if (tiempo.segundosActuales == 5)
                    {
                        puntos += 25;
                    }else if (tiempo.segundosActuales == 4)
                    {
                        puntos += 24;
                    }else if (tiempo.segundosActuales == 3)
                    {
                        puntos += 23;
                    }else if (tiempo.segundosActuales == 2)
                    {
                        puntos += 22;
                    }else if (tiempo.segundosActuales == 1)
                    {
                        puntos += 1;
                    }
                
                }
                else if(cliente.ComidasCanvas[cliente.valorRandom5].layer == juntar.spawner.layer)
                {
                    if(tiempo.segundosActuales == 59)
                    {
                        puntos += 70;
                    }
                    else if(tiempo.segundosActuales == 58)
                    {
                        puntos += 65;
                    }else if(tiempo.segundosActuales == 57)
                    {
                        puntos += 60;
                    }else if(tiempo.segundosActuales == 56)
                    {
                        puntos += 55;
                    }else if(tiempo.segundosActuales == 55)
                    {
                        puntos += 50;
                    }else if(tiempo.segundosActuales == 54)
                    {
                        puntos += 49;
                    }else if(tiempo.segundosActuales == 53)
                    {
                        puntos += 48;
                    }else if(tiempo.segundosActuales == 52)
                    {
                        puntos += 47;
                    }else if(tiempo.segundosActuales == 51)
                    {
                        puntos += 46;
                    }
                    else if(tiempo.segundosActuales == 50)
                    {
                        puntos += 40;                        
                    }
                    else if (tiempo.segundosActuales == 49)
                    {
                        puntos += 39;                        

                    }
                    else if (tiempo.segundosActuales == 48)
                    {
                        puntos += 38;
                    }
                    else if (tiempo.segundosActuales == 47)
                    {
                        puntos += 37;
                    }
                    else if (tiempo.segundosActuales == 46)
                    {
                        puntos += 36;
                    }
                    else if (tiempo.segundosActuales == 45)
                    {
                        puntos += 35;
                    }
                    else if (tiempo.segundosActuales == 44)
                    {
                        puntos += 34;
                    }
                    else if (tiempo.segundosActuales == 43)
                    {
                        puntos += 33;
                    }
                    else if (tiempo.segundosActuales == 42)
                    {
                        puntos += 32;
                    }
                    else if (tiempo.segundosActuales == 41)
                    {
                        puntos += 31;
                    }
                    else if (tiempo.segundosActuales == 40)
                    {
                        puntos += 30;
                    }
                    else if (tiempo.segundosActuales == 39)
                    {
                        puntos += 29;
                    }
                    else if (tiempo.segundosActuales == 38)
                    {
                        puntos += 28;
                    }else if (tiempo.segundosActuales == 37)
                    {
                        puntos += 27;
                    }else if (tiempo.segundosActuales == 36)
                    {
                        puntos += 26;
                    }else if (tiempo.segundosActuales == 35)
                    {
                        puntos += 25;
                    }else if (tiempo.segundosActuales == 34)
                    {
                        puntos += 24;
                    }else if (tiempo.segundosActuales == 33)
                    {
                        puntos += 23;
                    }else if (tiempo.segundosActuales == 32)
                    {
                        puntos += 22;
                    }else if (tiempo.segundosActuales == 31)
                    {
                        puntos += 1;
                    }
                
                }
                else if(cliente.ComidasCanvas[cliente.valorRandom6].layer == juntar.spawner.layer)
                {
                    if(tiempo.segundosActuales == 29)
                    {
                        puntos += 70;
                    }
                    else if(tiempo.segundosActuales == 28)
                    {
                        puntos += 65;
                    }else if(tiempo.segundosActuales == 27)
                    {
                        puntos += 60;
                    }else if(tiempo.segundosActuales == 26)
                    {
                        puntos += 55;
                    }else if(tiempo.segundosActuales == 25)
                    {
                        puntos += 50;
                    }else if(tiempo.segundosActuales == 24)
                    {
                        puntos += 49;
                    }else if(tiempo.segundosActuales == 23)
                    {
                        puntos += 48;
                    }else if(tiempo.segundosActuales == 22)
                    {
                        puntos += 47;
                    }else if(tiempo.segundosActuales == 21)
                    {
                        puntos += 46;
                    }
                    else if(tiempo.segundosActuales == 20)
                    {
                        puntos += 40;                        
                    }
                    else if (tiempo.segundosActuales == 19)
                    {
                        puntos += 39;                        

                    }
                    else if (tiempo.segundosActuales == 18)
                    {
                        puntos += 38;
                    }
                    else if (tiempo.segundosActuales == 17)
                    {
                        puntos += 37;
                    }
                    else if (tiempo.segundosActuales == 16)
                    {
                        puntos += 36;
                    }
                    else if (tiempo.segundosActuales == 15)
                    {
                        puntos += 35;
                    }
                    else if (tiempo.segundosActuales == 14)
                    {
                        puntos += 34;
                    }
                    else if (tiempo.segundosActuales == 13)
                    {
                        puntos += 33;
                    }
                    else if (tiempo.segundosActuales == 12)
                    {
                        puntos += 32;
                    }
                    else if (tiempo.segundosActuales == 11)
                    {
                        puntos += 31;
                    }
                    else if (tiempo.segundosActuales == 10)
                    {
                        puntos += 30;
                    }
                    else if (tiempo.segundosActuales == 9)
                    {
                        puntos += 29;
                    }
                    else if (tiempo.segundosActuales == 8)
                    {
                        puntos += 28;
                    }else if (tiempo.segundosActuales == 7)
                    {
                        puntos += 27;
                    }else if (tiempo.segundosActuales == 6)
                    {
                        puntos += 26;
                    }else if (tiempo.segundosActuales == 5)
                    {
                        puntos += 25;
                    }else if (tiempo.segundosActuales == 4)
                    {
                        puntos += 24;
                    }else if (tiempo.segundosActuales == 3)
                    {
                        puntos += 23;
                    }else if (tiempo.segundosActuales == 2)
                    {
                        puntos += 22;
                    }else if (tiempo.segundosActuales == 1)
                    {
                        puntos += 1;
                    }
                
                }
                
                
                generadorDePlatos.nuevo.SetActive(false);
                int condicion = tiempo.segundosActuales- 5;
                generadorDePlatos.cont--;

                
                
            } 
    }
    private void Awake() 
    {
        juntar=FindObjectOfType<CocinarJuntar>();    
    }
}
