using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabObject1 : MonoBehaviour
{
    public Transform grabDetect;
    public Transform grabItem;
    public Transform currentItem;
    public float rayDist;
    private bool hasItem = false;
    public Animator animator;


    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if(grabCheck.collider != null && grabCheck.collider.tag == "Items")
        {
            if(Input.GetKey(KeyCode.E))
            {

                if(!hasItem)
                
                {
                    currentItem = grabCheck.collider.gameObject.transform;
                    currentItem.parent = grabItem;
                    currentItem.transform.position = grabItem.position;
                    Destroy(grabCheck.collider.gameObject.GetComponent<Rigidbody2D>());
                    //grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                    hasItem = true;
                    
                    animator.SetBool("isGrab", true);

                }         
            
            }   


        }

        if(Input.GetKey(KeyCode.Z))

            if(hasItem)

            {   
                hasItem = false;
                this.currentItem.parent = null;
                this.currentItem = null;
                animator.SetBool("isGrab", false);
                
            } 

  
    }
}
