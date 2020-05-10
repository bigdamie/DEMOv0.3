using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTraits : ScriptableObject
{
    [SerializeField] public string itemType;
    [SerializeField] public string itemName;
    [TextArea(5,5)]
    [SerializeField] public string itemDescription;

    public float currentAverageValue;   
}
