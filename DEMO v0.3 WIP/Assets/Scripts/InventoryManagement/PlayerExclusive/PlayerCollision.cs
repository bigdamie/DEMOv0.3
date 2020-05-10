using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] PlayerInventory myInventory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            InvItem newItem = other.GetComponent<InvItem>();
            myInventory.AddItem(newItem);
        }
  
    }
}
