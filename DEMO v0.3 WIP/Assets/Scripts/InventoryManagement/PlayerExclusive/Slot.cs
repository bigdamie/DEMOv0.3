using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    InvItem itemInSlot;

    public Image itemIcon;

    [SerializeField] RectTransform iconRect;

    private void OnEnable()
    {
        itemIcon = GetComponentInChildren<Image>();
        iconRect = this.gameObject.GetComponentInChildren<RectTransform>();
    }

    public bool slotEmpty
    {
        get { return itemInSlot; }
    }

    public void AddItem(InvItem newItem)
    {
        itemInSlot = newItem;
        itemIcon.sprite = itemInSlot.icon;
    }
}
