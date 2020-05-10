using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
[CreateAssetMenu(menuName = "SO's/Item/Edible", fileName = "Edible")]
public class Edibles : ItemTraits
{
    public UnityEvent onConsumption;

    private void OnEnable()
    {
        this.itemType = "Edible";
    }

    public void Consume()
    {
        onConsumption.Invoke();
    }
}
