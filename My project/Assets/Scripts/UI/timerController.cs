using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerController : MonoBehaviour
{

    [SerializeField] private TMP_Text timerText;

    [SerializeField, Tooltip("tiempo en segundos")] private float timerTime;
    private int minutes, seconds;

    private void Update()
    {
        timerTime -= Time.deltaTime;

        if(timerTime < 0)
        
        {

          timerTime = 0;
        
        }
        
        
        
        minutes = (int)(timerTime /60f);
        
        seconds = (int)(timerTime - minutes * 60f);
        

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    
        if(timerTime == 0)
        {
            timerText.text = "FIN DEL TIEMPO";
        }
    
    }

}
