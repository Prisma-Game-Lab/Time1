using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryToggle : MonoBehaviour
{
    [SerializeField] private GameObject inventory;

    public void ToggleInventory()
    {
        if(inventory.activeSelf)
        {
            inventory.SetActive(false);
        }
        else
        {
            inventory.SetActive(true);
        }
    }

}
