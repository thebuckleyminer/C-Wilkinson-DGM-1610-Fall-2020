using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forward
        //transform.Translate(0, 0, 1); //Old Code uses coordinates instead of a Vector3
        transform.Translate(Time.deltaTime * 20 * Vector3.forward);
    }
}
