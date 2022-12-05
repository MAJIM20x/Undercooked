using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PescadoScripts : MonoBehaviour
{
    public void CambiarLayerCortado()
    {
        gameObject.layer = 24;
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
