using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollision : MonoBehaviour
{
    [SerializeField] PlayerInventory playerInventory;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {
            WorldItem newItem = other.GetComponent<WorldItem>();
            playerInventory.AddItem(newItem.thisItem);

            Destroy(other.gameObject);
        }
    }
}
