using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Player Inventory")]
public class PlayerInventory : Inventory
{
    InventoryManager invMan;

    private void OnEnable()
    {
        invMan = FindObjectOfType<InventoryManager>();
    }
}
