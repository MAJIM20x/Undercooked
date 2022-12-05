using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomateScripts : MonoBehaviour
{
    public void CambiarLayerCortado()
    {
        gameObject.layer = 23;
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
