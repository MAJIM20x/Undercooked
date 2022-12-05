using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapaScripts : MonoBehaviour
{
    public void CambiarLayerFrito()
    {
        gameObject.layer = 19;
    }
    public void CambiarLayerCortado()
    {
        gameObject.layer= 26;
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
