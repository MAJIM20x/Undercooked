using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class grabObject1 : MonoBehaviour
{  
    
    //Variables Publicas
    public Transform grabItem;
    public Transform currentItem;
    public Animator animator;

    //Variables Privadas
    private PlayerInputActions playerInputActions;
    private PlayerInput playerInput;
    private GameObject currentCollisionesItem;
    private GameObject currentCollisionesHolder;
    private bool hasItem = false;

    //Variables Serializadas
    [SerializeField] bool isOnRangeItem = false;
    [SerializeField] bool isOnRangeHolder = false;
    
    //Void Start
    void Start()
    {   
        playerInput = GetComponent<PlayerInput>();
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
    }

    //Void Update
    void FixedUpdate()
    {   
    
        this.itemGrabber();              
    }

    //Void de LateUpdate
    private void LateUpdate()
    {
        this.itemDeGrabber();
    }   
    
    //Metodo agarra objetos
    private void itemGrabber()
    {
        if(isOnRangeItem && !hasItem && playerInputActions.Interactions.Grab.ReadValue<float>() > 0.1f)
        {
            currentItem = currentCollisionesItem.transform;
            currentItem.parent = grabItem;
            currentItem.transform.position = grabItem.position;
            Destroy(currentCollisionesItem.GetComponent<Rigidbody2D>());
            hasItem = true;
            animator.SetBool("isGrab", true);
        }
    }
    
    //Metodo bota objetos
    private void itemDeGrabber()
    {
        if(hasItem && playerInputActions.Interactions.Drop.ReadValue<float>() > 0.1f && isOnRangeHolder)
        {   
              
            
            this.currentItem.parent = null;
            currentItem.position = new Vector2((int)this.transform.position.x + animator.GetFloat("horizontal"),(int)this.transform.position.y + animator.GetFloat("vertical"));
            this.currentItem = null;
            animator.SetBool("isGrab", false);
            

            hasItem = false;
            
        }

    }
    
    //Esta dentro del rango
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Items"))
        {
            isOnRangeItem = true;
            currentCollisionesItem = other.gameObject;
        }   

        if(other.CompareTag("Holder"))
        {
            isOnRangeHolder = true;
            currentCollisionesHolder = other.gameObject;
        } 
       
    }
    
    //Ya no esta dentro del rango
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Items"))
        {
            isOnRangeItem = false;
            currentCollisionesItem = null;
        }   

        if(other.CompareTag("Holder"))
        {
            isOnRangeHolder = false;
            currentCollisionesHolder = null;
        } 
        
    }

  
  
    
}
