using System;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsNew : MonoBehaviour
{
    public List<CollectibleItem> collectibleList;

    private void Start()
    {
        
        for (var i = 0; i < collectibleList.Count; i++)
        {
            var item = collectibleList[i];
            var position = new Vector3(i*1.25f,0,0);
            var newItem = new GameObject(item.name);
            newItem.transform.position = position;
            var sprite = newItem.AddComponent<SpriteRenderer>();
            sprite.sprite = item.art;
            sprite.color = item.artColor;
            
            //OLD
            //print(item.art);
            //print(item.artColor);
            //print(item.cashValue);
            //print(item.powerLevel);
            
            //Vector3 position = new Vector3();
        }
    }
}
