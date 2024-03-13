using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventorymanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Inventorymanager Instance;
    public Transform ItemContent;
    public GameObject InventoryItem;
    public List<Itemsobjects> Items= new List<Itemsobjects>();
    private void Awake()
    {
        Instance = this;
    }
    public void Add(Itemsobjects item)
    {
        Items.Add(item);
    }
    public void remove(Itemsobjects item)
    {
        Items.Remove(item);
    }
    public void Listitems()
    {
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            
            itemName.text = item.name;
            itemIcon.sprite = item.icon;
        }
    }
}
