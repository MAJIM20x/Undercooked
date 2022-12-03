using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movimientoJugador1 : MonoBehaviour
{   
    //Variables serializadas
    [SerializeField]private float walk = 3f;
    [SerializeField]private float run = 5f;
    
    
    //Variables no serializadas
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;
    private Animator animator;
    private Vector2 inputVector;
    
    
    //Obtener componentes para los metodos
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        animator = GetComponent<Animator>();
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
        
    }
    
   
    private void FixedUpdate()
    {
       
        
        inputVector = playerInputActions.Movement.MovementDpad.ReadValue<Vector2>();
        float moveX = inputVector.x;
        float moveY = inputVector.y;
        
        if (moveX != 0 || moveY != 0) 
        {
            animator.SetFloat("vertical", moveY);
            animator.SetFloat("horizontal", moveX);
            animator.SetFloat("speed", 1);
        }

        else
        {
            animator.SetFloat("speed", 0);
        }

        playerRb.MovePosition(playerRb.position + inputVector * walk * Time.fixedDeltaTime);

        if(playerInputActions.Interactions.Dash.ReadValue<float>() > 0.1f)
        {
            playerRb.MovePosition(playerRb.position + inputVector * run * Time.fixedDeltaTime);
        }

       
    }



}
