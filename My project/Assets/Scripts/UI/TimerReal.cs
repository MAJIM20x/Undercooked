using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerReal : MonoBehaviour
{
    public int minutosActuales;
    public int segundosActuales;
    [SerializeField] int min;
    [SerializeField] int sec;
    [SerializeField] TextMeshProUGUI tiempo;
    private float restante;
    private bool comenzar = true;
    private void Awake() 
    {
        restante = (min * 60) + sec;
    }

    // Update is called once per frame
    void Update()
    {
        if(comenzar)
        {
            restante -= Time.deltaTime;
            int tempMinut = Mathf.FloorToInt(restante/60);
            int tempSec = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00} : {01:00}", tempMinut, tempSec);
            minutosActuales = tempMinut;
            segundosActuales = tempSec;
            if(tempMinut == 10 && tempSec == 0)
            {
                print("hola");
            }


        }
    }
}
