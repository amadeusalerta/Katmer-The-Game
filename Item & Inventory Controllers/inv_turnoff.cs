using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inv_turnoff : MonoBehaviour
{
    public GameObject inventory;
    public bool inventory_is_close;

    private void Start()
    {
        inventory_is_close = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventory_is_close == true)
            {
                inventory.SetActive(true);
                inventory_is_close = false;
            }

            else
            {
                inventory.SetActive(false);
                inventory_is_close = true;
            }
        }

       
    }
}
