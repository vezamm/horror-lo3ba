using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itempickup : MonoBehaviour
{
    public Itemsobjects items;
    void pickup()
    {
        Inventorymanager.Instance.Add(items);
        Destroy(gameObject);
    }
}
