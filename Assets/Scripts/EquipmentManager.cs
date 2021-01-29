using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    public Transform player;

    public EquipmentSlot helmet { get; set; }
    public EquipmentSlot horns { get; set; }
    public EquipmentSlot neck { get; set; }
    public EquipmentSlot shoulderL { get; set; }
    public EquipmentSlot shoulderR { get; set; }
    public EquipmentSlot upperArmL { get; set; }
    public EquipmentSlot upperArmR { get; set; }
    public EquipmentSlot lowerArmL { get; set; }
    public EquipmentSlot lowerArmR { get; set; }
    public EquipmentSlot handL { get; set; }
    public EquipmentSlot handR { get; set; }
    public EquipmentSlot upperStomach { get; set; }
    public EquipmentSlot belt { get; set; }
    public EquipmentSlot groin { get; set; }
    public EquipmentSlot upperLegL { get; set; }
    public EquipmentSlot upperLegR { get; set; }
    public EquipmentSlot shinR { get; set; }
    public EquipmentSlot shinL { get; set; }
    public EquipmentSlot backpack { get; set; }
    public EquipmentSlot weaponL { get; set; }
    public EquipmentSlot weaponR { get; set; }
    public EquipmentSlot weaponStowedR { get; set; }
    public EquipmentSlot bowStowed { get; set; }
    public EquipmentSlot shieldStowed { get; set; }
    public EquipmentSlot staffStowed { get; set; }


    InventoryManager inventory;



    public void Start()
    {
        inventory = GameObject.Find("Inventory").GetComponent<InventoryManager>();

        //Getting all the Item EquipmentSlot Scripts
        helmet = player.Find("HeadArmorSlot").GetComponent<EquipmentSlot>();
        horns = player.Find("HornsArmorSlot").GetComponent<EquipmentSlot>();
        neck = player.Find("NeckArmorSlot").GetComponent<EquipmentSlot>();
        shoulderL = player.Find("ShoulderArmorSlotLeft").GetComponent<EquipmentSlot>();
        shoulderR = player.Find("ShoulderArmorSlotRight").GetComponent<EquipmentSlot>();
        upperArmL = player.Find("UpperArmArmorSlotLeft").GetComponent<EquipmentSlot>();
        upperArmR = player.Find("UpperArmArmorSlotRight").GetComponent<EquipmentSlot>();
        lowerArmL = player.Find("LowerArmArmorSlotLeft").GetComponent<EquipmentSlot>();
        lowerArmR = player.Find("LowerArmArmorSlotRight").GetComponent<EquipmentSlot>();
        handL = player.Find("HandArmorSlotLeft").GetComponent<EquipmentSlot>();
        handR = player.Find("HandArmorSlotRight").GetComponent<EquipmentSlot>();
        upperStomach = player.Find("UpperStomachArmorSlot").GetComponent<EquipmentSlot>();
        belt = player.Find("HipArmorSlot").GetComponent<EquipmentSlot>();
        groin = player.Find("GroinArmorSlot").GetComponent<EquipmentSlot>();
        upperLegL = player.Find("UpperLegArmorSlotLeft").GetComponent<EquipmentSlot>();
        upperLegR = player.Find("UpperLegArmorSlotRight").GetComponent<EquipmentSlot>();
        shinR = player.Find("ShinArmorSlotRight").GetComponent<EquipmentSlot>();
        shinL = player.Find("ShinArmorSlotLeft").GetComponent<EquipmentSlot>();
        weaponL = player.Find("WeaponHandLeft").GetComponent<EquipmentSlot>();
        weaponR = player.Find("WeaponHandRight").GetComponent<EquipmentSlot>();

        weaponR = player.Find("BackpackSlot").GetComponent<EquipmentSlot>();
        weaponStowedR = player.Find("BowStowedSlot").GetComponent<EquipmentSlot>();
        shieldStowed = player.Find("ShieldStowedSlot").GetComponent<EquipmentSlot>();
        staffStowed = player.Find("StaffStowedSlot").GetComponent<EquipmentSlot>();


    }

    /*
        public void Equip(Item newItem)
        {
            Item tempItem;

            switch (newItem.equipmentSlot)
            {

                case Item.EquipmentSlot.Helmet:
                    if (helmet != null)
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

        */
}
