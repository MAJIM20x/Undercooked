using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerPs4 : MonoBehaviour
{
    
    GameObject jugador = null;
    GameObject jugador2 = null;
    GameObject jugador3 = null;
    GameObject jugador4 = null;
    // Start is called before the first frame update
    void Start()
    {
   
        for(int i = 0;i< Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }
        jugador = GameObject.Find("Jugador");
        jugador2 = GameObject.Find("Jugador2");
        jugador3 = GameObject.Find("Jugador3");  
        jugador4 = GameObject.Find("Jugador4");
    }

    // Update is called once per frame
    void Update()
    {
     if(Gamepad.all.Count>0)
     {
        if(Gamepad.all[0].leftStick.left.isPressed)
        {
            jugador.transform.position += Vector3.left * Time.deltaTime * 1f;
        }
        if(Gamepad.all[0].leftStick.right.isPressed)
        {
            jugador.transform.position += Vector3.right * Time.deltaTime * 1f;
        }
        if(Gamepad.all[0].leftStick.up.isPressed)
        {
            jugador.transform.position += Vector3.up * Time.deltaTime * 1f;
        }
        if(Gamepad.all[0].leftStick.down.isPressed)
        {
            jugador.transform.position += Vector3.down * Time.deltaTime * 1f;
        }
        if(Gamepad.all[1].leftStick.left.isPressed)
        {
            jugador2.transform.position += Vector3.left * Time.deltaTime * 1f;
        }
        if(Gamepad.all[1].leftStick.right.isPressed)
        {
            jugador2.transform.position += Vector3.right * Time.deltaTime * 1f;
        }
        if(Gamepad.all[1].leftStick.up.isPressed)
        {
            jugador2.transform.position += Vector3.up * Time.deltaTime * 1f;
        }
        if(Gamepad.all[1].leftStick.down.isPressed)
        {
            jugador2.transform.position += Vector3.down * Time.deltaTime * 1f;
        }
        if(Gamepad.all[2].leftStick.left.isPressed)
        {
            jugador3.transform.position += Vector3.left * Time.deltaTime * 1f;
        }
        if(Gamepad.all[2].leftStick.right.isPressed)
        {
            jugador3.transform.position += Vector3.right * Time.deltaTime * 1f;
        }
        if(Gamepad.all[2].leftStick.up.isPressed)
        {
            jugador3.transform.position += Vector3.up * Time.deltaTime * 1f;
        }
        if(Gamepad.all[2].leftStick.down.isPressed)
        {
            jugador3.transform.position += Vector3.down * Time.deltaTime * 1f;
        }
        if(Gamepad.all[3].leftStick.left.isPressed)
        {
            jugador4.transform.position += Vector3.left * Time.deltaTime * 1f;
        }
        if(Gamepad.all[3].leftStick.right.isPressed)
        {
            jugador4.transform.position += Vector3.right * Time.deltaTime * 1f;
        }
        if(Gamepad.all[3].leftStick.up.isPressed)
        {
            jugador4.transform.position += Vector3.up * Time.deltaTime * 1f;
        }
        if(Gamepad.all[3].leftStick.down.isPressed)
        {
            jugador4.transform.position += Vector3.down * Time.deltaTime * 1f;
        }
     } 
    }
}
