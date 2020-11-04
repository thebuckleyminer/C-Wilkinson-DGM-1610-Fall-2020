using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter(Collider other)
    {
        value++;
    }
}
