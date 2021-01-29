using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSlot : MonoBehaviour
{

    public enum Slot
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


    public Slot slot;
    Item equipped { get; set; }
    public bool hasMirror;
    public bool isEmpty { get; private set; } = true;
    private InventoryManager inventory;


    public void Start()
    {
        inventory = GameObject.Find("Inventory").GetComponent<InventoryManager>();
    }

    public void Equip(Item newItem)
    {
        if (newItem != null && newItem.equipmentSlot.ToString() == slot.ToString())
        {

            if (inventory.AddItem(equipped, 1))
            {
                if (equipped != null)
                {
                    equipped.RemoveStats();  //remove the stats of the old item
                }              

                equipped = newItem;         //sets the new item

                //Add Item Mesh to the right position -> this.transform

                equipped.ApplyStats();      //applies the Stats of the new Item
            }
            else
            {
                Debug.LogWarning("You must make room in your inventory before you can equip this item");
            }


        }

    }

    public void Unequip()
    {
        if (equipped != null)
        {
            if (inventory.AddItem(equipped, 1))
            {
                equipped.RemoveStats();
            }
            else
            {
                Debug.Log("You must make space in your inventory.");
            }

        }
        else
        {
            Debug.Log("You can't unequip an item that is not equipeed");
        }

    }


}
