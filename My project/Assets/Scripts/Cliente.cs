using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StateMachine{none, eating, waiting,walking }

public class Cliente : MonoBehaviour
{
    [SerializeField] private StateMachine currenStateClient;
    [SerializeField] private float velocidadMovimiento;
    
}
