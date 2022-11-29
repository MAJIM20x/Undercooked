using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class SceneMenu : MonoBehaviour
{
    [SerializeField] private bool isInside;
    public Rigidbody2D rb;
    public Collider2D box;
    public GameObject Player;   

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Choque1");
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("posicionX",(int)this.transform.position.x);
            PlayerPrefs.SetInt("posicionY",(int)this.transform.position.y);
            Debug.Log("Cambio escena");
        }
    }
    public void loadPosicion()
    {
        Player.transform.position = new Vector2( PlayerPrefs.GetFloat("X"),PlayerPrefs.GetFloat("Y"));
        
    }
    
}
