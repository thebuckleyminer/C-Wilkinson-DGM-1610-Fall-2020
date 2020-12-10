using System;
using UnityEngine;
using UnityEngine.UI;

public class CollectCash : MonoBehaviour
{
    public IntData cashTotal;
    public CollectibleItem collectibleObj;
    public Text txtObj;
    private SpriteRenderer rendererVar;

    private void Start()
    {
        rendererVar = GetComponent<SpriteRenderer>();
        rendererVar.sprite = collectibleObj.art;
        rendererVar.color = collectibleObj.artColor;
        txtObj.text = cashTotal.value.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        cashTotal.value += collectibleObj.cashValue;
        txtObj.text = cashTotal.value.ToString();
        gameObject.SetActive(false);
    }
    
    
    
    
}
