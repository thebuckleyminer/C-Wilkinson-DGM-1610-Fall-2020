using System;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public string singleString;
    public List<string> collectionList;
    public List<GameObject> gameObjectList;

    private void Start()
    {
        foreach (var item in collectionList)
        {
           print(item); 
        }

        foreach (var item in gameObjectList)
        {
            print(item);
        }
    }
}
