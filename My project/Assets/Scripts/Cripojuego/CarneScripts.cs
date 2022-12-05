using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarneScripts : MonoBehaviour
{
   public void CambiarLayerCocido()
    {
        gameObject.layer = 18;
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
