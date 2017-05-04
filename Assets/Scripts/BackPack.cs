using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackPack : MonoBehaviour
{
    public Item addItem;
    public List<Item> Invetory;
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invetory.Add(addItem);
        }
    }
}
