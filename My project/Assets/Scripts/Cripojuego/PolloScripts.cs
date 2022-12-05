using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolloScripts : MonoBehaviour
{
    public void CambiarLayerFrito()
    {
        gameObject.layer = 22;
    }
    public void CambiarLayerCocido()
    {
        gameObject.layer= 21;
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
