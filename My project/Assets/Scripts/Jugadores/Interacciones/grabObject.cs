using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabObject : MonoBehaviour
{  
    //Variables Publicas
    public Transform grabDetect;
    public Transform grabItem;
    public Transform currentItem;
    public float rayDist;
    public Animator animator;
    
    //Variables privadas 
    private bool hasItem = false;
    
    //
    [SerializeField] bool isOnRange = false;
    private GameObject currentCollisionesItem;


    void Update()
    {
        this.itemGrabber();
    }

    private void LateUpdate()
    {
        this.itemDeGrabber();
    }
  
    private void itemGrabber()
    {
       if(Input.GetKey(KeyCode.E) && isOnRange && !hasItem)
        {
            currentItem = currentCollisionesItem.transform;
            currentItem.parent = grabItem;
            currentItem.transform.position = grabItem.position;
            
            hasItem = true;
            animator.SetBool("isGrab", true);      
        }  
    }

    private void itemDeGrabber()
    {
        if(Input.GetKey(KeyCode.Z))
        {

            if(hasItem)

            {   
                hasItem = false;
                this.currentItem.parent = null;
                this.transform.position = new Vector2((int)this.transform.position.x + animator.GetFloat("horizontal"),(int)this.transform.position.y + animator.GetFloat("vertical"));
                this.currentItem = null;
                
                animator.SetBool("isGrab", false);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Items"))
        {
            isOnRange = true;
            currentCollisionesItem = other.gameObject;
        }   
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Items"))
        {
            isOnRange = false;
            currentCollisionesItem = null;
        }   
    }
}
