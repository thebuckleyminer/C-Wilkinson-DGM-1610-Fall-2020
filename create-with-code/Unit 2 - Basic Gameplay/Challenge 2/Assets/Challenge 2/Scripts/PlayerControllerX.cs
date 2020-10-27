using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int holdingValue = 0;

    // Update is called once per frame
    void Update()
    {
        if (holdingValue == 0)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                holdingValue = 100;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
        else
        {
            holdingValue -= 1;
        }

    }
}
