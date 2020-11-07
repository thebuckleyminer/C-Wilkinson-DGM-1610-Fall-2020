using System;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class ImageBehavior : MonoBehaviour
{
    private Image img;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    public void DisplayValue(FloatData data)
    {
        img.fillAmount = data.value;
    }
}
