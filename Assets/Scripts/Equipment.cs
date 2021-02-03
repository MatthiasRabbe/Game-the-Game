using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public Item helmet;
    public Item horns;
    public Item neck;
    public Item shoulder;
    public Item upperArm;
    public Item lowerArm;
    public Item hand;
    public Item belt;
    public Item groin;
    public Item upperLeg;
    public Item shin;
    public Item backpack;


    InventoryManager inventory;


    public void Start()
    {
        inventory = GameObject.Find("Inventory").GetComponent<InventoryManager>();
    }

    public void Equip(Item newItem)
    {
        Item tempItem;

        switch (newItem.equipmentSlot)
        { 

            case Item.EquipmentSlot.Helmet:
                if(helmet != null)
                {
                    tempItem = helmet;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        helmet = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }               
                break;

            case Item.EquipmentSlot.Horns:
                if (horns != null)
                {
                    tempItem = horns;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        horns = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.Neck:
                if (neck != null)
                {
                    tempItem = neck;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        neck = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.Shoudler:
                if (shoulder != null)
                {
                    tempItem = shoulder;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        shoulder = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.UpperArm:
                if (upperArm != null)
                {
                    tempItem = upperArm;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        upperArm = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.LowerArm:
                if (lowerArm != null)
                {
                    tempItem = lowerArm;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        lowerArm = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.Hand:
                if (hand != null)
                {
                    tempItem = hand;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        hand = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.Belt:
                if (belt != null)
                {
                    tempItem = belt;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        belt = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.Groin:
                if (groin != null)
                {
                    tempItem = groin;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        groin = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.UpperLeg:
                if (upperLeg != null)
                {
                    tempItem = upperLeg;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        upperLeg = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.Shin:
                if (shin != null)
                {
                    tempItem = shin;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        shin = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;
            case Item.EquipmentSlot.Backpack:
                if (backpack != null)
                {
                    tempItem = backpack;
                    if (inventory.AddItem(tempItem, 1))
                    {
                        backpack = newItem;
                    }
                }
                else
                {
                    Debug.LogWarning("You need more space in your inventory first if you wish to equip this item");
                }
                break;


        }



    }


}
