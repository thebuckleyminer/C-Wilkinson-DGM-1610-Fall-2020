using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TextCounter : MonoBehaviour
{
    private Text textObj;
    public float textTimeDelay = 1f;
    public UnityEvent goEvent;

    IEnumerator Start()
    {
        textObj = GetComponent<Text>();
        textObj.text = "3";
        var i = 3;
        while (i>0)
        {
            textObj.text = i.ToString();
            yield return new WaitForSeconds(textTimeDelay);
            i--;
        }
        textObj.text = "GO!";
        yield return new WaitForSeconds(textTimeDelay);
        textObj.text = "";
        goEvent.Invoke();

    }
}
