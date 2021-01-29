using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    public enum EquipmentSlot
    {
        Head,
        Horns,
        Neck,
        Shooulder,
        UpperArm,
        LowerArm,
        Hand,
        WeaponL,
        WeaponR,
        Torso,
        UpperStomach,
        Belt,
        Groin,
        UpperLeg,
        Shin,
        Ankle,
        Backpack,
        Staff,
        Bow,
        None
    }

    [SerializeField]
    protected string itemName;
    [SerializeField]
    protected int buyValue;
    [SerializeField]
    protected int sellValue;
    [SerializeField]
    protected GameObject itemPrefab;
    [SerializeField]
    protected Sprite itemImage;
    [SerializeField]
    private int stacksize;
    [SerializeField]
    public EquipmentSlot equipmentSlot = EquipmentSlot.None;


    void IncreaseSellValue(int increase)
    {
        sellValue += increase;
    }

    public Sprite GetItemImage()
    {
        return itemImage;
    }

    public GameObject GetItemPrefab()
    {
        return itemPrefab;
    }

    public void SetItemPrefab(GameObject newPrefab)
    {
        itemPrefab = newPrefab;
    }

    public int GetMaximumStackSize()
    {
        return stacksize;
    }

    public string GetName()
    {
        return itemName;
    }

    public virtual void ApplyStats()
    {
        //does nothing for unequipable Items
    }

    public virtual void RemoveStats()
    {
        //does nothing for unequipable Items
    }

   
}
