using TMPro;
using UnityEngine;
using System.Collections.Generic;

// This is for the player's inventory GUI and stuff
public class InventoryManager : MonoBehaviour
{
    public PlayerInventory theInventory;
    [SerializeField] TextMeshProUGUI descText;
    [SerializeField] InvItem currItem;

    RectTransform inventoryRect;
    float inventoryWidth, inventoryHeight;

    public int slots;
    public int rows;

    public float slotPaddingHor, slotPaddingVer;
    public float slotSize;

    public GameObject slotPrefab;
    public List<GameObject> allSlots;

    int emptySlots;


    private void Update()
    {
        //Get rid of this once done testing!

        if (Input.GetButtonDown("Pause"))
            CreateLayout();
    }

    private void Start()
    {
        CreateLayout();
    }

    void CreateLayout()
    {
        //Only at the start of the game
        emptySlots = slots;

        allSlots = new List<GameObject>();

        inventoryWidth = ((slots / rows) * (slotSize + slotPaddingHor) + slotPaddingHor);
        inventoryHeight = (rows * (slotSize + slotPaddingVer) + slotPaddingVer);

        inventoryRect = GetComponent<RectTransform>();
        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, inventoryWidth);
        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, inventoryHeight);

        int columns = slots / rows;

        for(int y=0; y<rows;y++)
        {
            for (int x = 0; x < columns; x++)
            {
                GameObject newSlot = Instantiate(slotPrefab) as GameObject;

                RectTransform slotRect = newSlot.GetComponent<RectTransform>();
                newSlot.name = "Slot";
                newSlot.transform.SetParent(this.transform.parent);

                slotRect.localPosition = inventoryRect.localPosition + new Vector3(slotPaddingHor * (x+1) + (slotSize * x), -slotPaddingVer * (y+1) - (slotSize * y) );
                slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize);
                slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize);

               
                allSlots.Add(newSlot);
            }
        }
    }

    public bool PlaceEmpty(InvItem newItem)
    {
        if(emptySlots > 0 )
        {
            foreach(GameObject slot in allSlots)
            {
                Slot temp = slot.GetComponent<Slot>();
                if(temp.slotEmpty)
                {
                    temp.AddItem(newItem);
                    emptySlots--;
                    return true;
                }
            }
        }

        return false;
    }

    public void SetCurrentItem(InvItem newItem)
    {
        if (theInventory.thisInventory.Contains(newItem))
        {
            currItem = newItem;

            descText.text = currItem.myTraits.itemDescription;
        }
        else
            Debug.Log("Somehow, you tried to make an item\n" +
                      "That isn't in the inventory the selected item.");
    }
}
