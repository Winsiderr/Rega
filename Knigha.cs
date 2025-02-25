using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Knigha : MonoBehaviour
{

    private void OnEnable()
    {
        Eventer.noTorch += Messedge;
    }
    private void OnDisable()
    {
        Eventer.noTorch -= Messedge;
    }


    private void Messedge()
    {
        print("sdf");
    }
}
