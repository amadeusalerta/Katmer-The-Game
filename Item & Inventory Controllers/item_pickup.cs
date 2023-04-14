using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_pickup : MonoBehaviour
{

    public item_sc Item;

    void Pickup()
    {
        inventory_manager.Instance.Add(Item);
        Destroy(gameObject);

    }

    private void OnMouseDown()
    {
        Pickup();
    }

}
