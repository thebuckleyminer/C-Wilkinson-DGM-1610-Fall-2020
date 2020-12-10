using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;
    public UnityEvent onZeroEvent;
    
    public void UpdateValue(float number)
    {
        value += number;
    }

    public void DiplayImage(Image img)
    {
        if (value <= 0)
        {
            onZeroEvent.Invoke();
        }

        if (value >= 1)
        {
            value = 1;
        }
        
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
    public void ReplaceValue(float number)
    {
        value = number;
    }
}
