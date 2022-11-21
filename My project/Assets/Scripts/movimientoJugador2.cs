using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador2 : MonoBehaviour
{   
    //Variables serializadas
    [SerializeField]private float walk = 3f;
    [SerializeField]private float run = 5f;

    //Variables no serializadas
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    public Animator animator;
    
    //Obtener componentes de los metodos
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        //Teclas para caminar en X e Y
        float moveX = Input.GetAxisRaw("Horizontal2");
        float moveY = Input.GetAxisRaw("Vertical2");
        moveInput = new Vector2(moveX, moveY).normalized;
            
        
        if (moveX != 0 || moveY != 0) {
            animator.SetFloat("vertical", moveY);
            animator.SetFloat("horizontal", moveX);
            animator.SetFloat("speed", 1);

        }

        else
        {
            animator.SetFloat("speed", 0);
        }
    
    
    }


    private void FixedUpdate()
    {   
        //Actualizacion de movimiento por segundo constante
        playerRb.MovePosition(playerRb.position + moveInput * walk * Time.fixedDeltaTime);

        //Tecla para correr
        if(Input.GetKey(KeyCode.Q))
        
        {
            playerRb.MovePosition(playerRb.position + moveInput * run * Time.fixedDeltaTime);
        }

    }
}
