using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Inventory", fileName = "New Inventory")]
//This is the actual Inventory itselfSs
public class Inventory : ScriptableObject
{
    public List<InvItem> thisInventory = new List<InvItem>();

    public void AddItem(InvItem newItem)
    {
        if(!thisInventory.Contains(newItem))
        {
            thisInventory.Add(newItem);
        }
    }

    public void RemoveItem(InvItem newItem)
    {
        if (!thisInventory.Contains(newItem))
        {
            thisInventory.Remove(newItem);
        }
    }
}
