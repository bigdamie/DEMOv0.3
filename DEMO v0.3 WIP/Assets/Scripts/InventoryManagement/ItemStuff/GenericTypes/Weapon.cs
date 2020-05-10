using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName ="SO's/Item/Weapon", fileName = "Weapon")]
public class Weapon : ItemTraits
{
    [SerializeField] float damage;
    [SerializeField] float knockback;


    private void OnEnable()
    {
        this.itemType = "Weapon";
    }
}
