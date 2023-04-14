using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory_manager : MonoBehaviour
{

    public static inventory_manager Instance;
    public List<item_sc> Items = new List<item_sc>();

    private void Awake()
    {
        Instance = this;
    }

    public void Add(item_sc item)
    {
        Items.Add(item);

    }

    public void Remove(item_sc item)
    {
        Items.Remove(item);
    }
}
