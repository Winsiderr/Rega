using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Eventer : MonoBehaviour
{

    //public delegate void Mydelegate();
    //public static event Mydelegate noTorch;

    public static Action noTorch;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Я наебнулся");
        noTorch?.Invoke(); 
    }
}

