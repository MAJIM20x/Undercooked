using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador1 : MonoBehaviour
{   
    //Variables serializadas
    [SerializeField]private float walk = 3f;
    [SerializeField]private float run = 5f;
    
    
    //Variables no serializadas
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    public Animator animator;

    
    
    
    
    //Obtener componentes para los metodos
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {   
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
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
        playerRb.MovePosition(playerRb.position + moveInput * walk * Time.fixedDeltaTime);

        //Tecla para correr
        if(Input.GetKey(KeyCode.P))
        
        {
            playerRb.MovePosition(playerRb.position + moveInput * run * Time.fixedDeltaTime);
        }

    }
}
