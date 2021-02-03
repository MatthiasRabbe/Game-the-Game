using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    public enum EquipmentSlot
    {
        Helmet,
        Horns,
        Neck,
        Shoudler,
        UpperArm,
        LowerArm,
        Hand,
        Belt,
        Groin,
        UpperLeg,
        Shin,
        Backpack,
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
        if (stacksize <= 0)
        {
            stacksize = 1;
        }

        return stacksize;
    }

    public string GetName()
    {
        return itemName;
    }
}
