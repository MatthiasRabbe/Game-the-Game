using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Consumable", menuName = "ScriptableObjects/Consumable", order = 2)]
public class Consumable : Item
{

    [SerializeField]
    private string benefit;
    [SerializeField]
    private bool canHeal;
    [SerializeField]   
    private bool isUsedUp;
    [SerializeField] 
    private float healingAmount;
    


    public void Heal()
    {
        //Target: Player
        //Heal Player Health
    }

    public void UseUp(bool isDepleted)
    {
        isUsedUp = isDepleted;
    }

    public void CanHeal(bool canHeal)
    {
        isUsedUp = canHeal;
    }

    public bool GetCanHeal()
    {
        return canHeal;
    }
    public bool IsUsedUp()
    {
        return isUsedUp;
    }

    public string GetBeneftig()
    {
        return benefit;
    }
    public float GetHealing()
    {
        return healingAmount;
    }
  

}
