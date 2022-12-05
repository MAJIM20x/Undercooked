using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrozScripts : MonoBehaviour
{
    public void CambiarLayerCocido()
    {
        gameObject.layer = 20;
    }
    public void desaparecer()
    {

        gameObject.SetActive(false);
    }
    public void aparecer()
    {
        gameObject.SetActive(true);
    }
    
}
