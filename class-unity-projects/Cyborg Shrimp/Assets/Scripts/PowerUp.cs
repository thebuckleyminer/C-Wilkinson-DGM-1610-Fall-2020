using System;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        print("Trigger");
        score++;
        print(score);
    }
}
