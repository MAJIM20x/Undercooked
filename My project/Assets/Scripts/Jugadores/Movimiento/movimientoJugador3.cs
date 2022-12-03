using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador3 : MonoBehaviour
{
    //Variables serializadas
    [SerializeField]private float walk = 3f;
    [SerializeField]private float run = 5f;

    //Variables no serializadas
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;
    
    //Obtener componentes de los metodos
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {
        //Teclas para caminar en X e Y
        float moveX = Input.GetAxisRaw("Horizontal3");
        float moveY = Input.GetAxisRaw("Vertical3");
        moveInput = new Vector2(moveX, moveY).normalized;
            
        //Se cita al componente "Animator"
        playerAnimator.SetFloat("Horizontal", moveX);
        playerAnimator.SetFloat("Vertical", moveY);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);
    }

    private void FixedUpdate()
    {   
        //Actualizacion de movimiento por segundo constante
        playerRb.MovePosition(playerRb.position + moveInput * walk * Time.fixedDeltaTime);

        //Tecla para correr
        if(Input.GetKey(KeyCode.U))
        
        {
            playerRb.MovePosition(playerRb.position + moveInput * run * Time.fixedDeltaTime);
        }

    }
}
