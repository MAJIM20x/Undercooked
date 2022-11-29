using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    public float timeValue = 90;
    void Update()
    {   
        if(timeValue > 0)
        {
        timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
    }

    void displayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        
        float minutes = Mathf.FloorToInt(timeToDisplay);
    }
}
