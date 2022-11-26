using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMenu : MonoBehaviour
{
    [SerializeField] private bool isInside;
    public Rigidbody2D rb;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Choque");
            isInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Choque");
            isInside = false;
        }
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.F) && isInside)
        {
            Debug.Log("Cambio escena");
        }
    }
}
