﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stats : MonoBehaviour
{
    public static Stats Instance;
    

    [SerializeField]
    public int gold;

    [SerializeField]
    public float baseHitpoints;
    [SerializeField]
    public float currentHitpoints;
    [SerializeField]
    public float hitpointsBonus;
    [SerializeField]

    private float baseStamina;
    [SerializeField]
    private float currentStamina;
    [SerializeField]
    private float staminaBonus;

    [SerializeField]
    private float baseArmor;
    [SerializeField]
    private float currentArmor;
    [SerializeField]
    private float armorBonus;

    [SerializeField]
    private int baseExperience;
    [SerializeField]
    private int currentExperience;
    [SerializeField]
    private int experienceGainBonus;

    [SerializeField]
    public int level;
    [SerializeField]
    public string characterName;

    [SerializeField]
    public int[] levelProgressionArray = {100 , 500 , 750, 1200, 1800, 2500, 3000,
                                            4000, 5000, 6500, 7500, 8200, 9000, 10500,
                                                12000, 15000, 20000, 25000 ,29000, 300000 };


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void Start()
    {
        if (experienceGainBonus <= 0)
            experienceGainBonus = 1;

        if (level <= 0)
            level = 1;

        currentExperience = baseExperience;
    }
  

    public void AddExperience(int xP)
    {
        //Adding the XP
        currentExperience +=  xP * experienceGainBonus;

        for (int i = level -1; i < levelProgressionArray.Length; i++)
        {
            try
            {
                if (currentExperience >= levelProgressionArray[i])
                {
                    level += 1;
                    LevelUp();
                }
            }
            catch
            {
                Debug.Log("Level " + level + " ist the current maximum level.");
            }
        }
       
    }


    public void AddHealth(int health)
    {
           hitpointsBonus += health;

           currentHitpoints = baseHitpoints + hitpointsBonus;

           currentHitpoints = Mathf.Clamp(currentHitpoints, 0 , baseHitpoints + hitpointsBonus);
    }

    public void LevelUp()
    {
        baseStamina += level +1;
        baseArmor += level +1;
        baseHitpoints += level * 2;

        currentStamina = baseStamina + staminaBonus;
        currentHitpoints = baseHitpoints + hitpointsBonus;
        currentArmor = baseArmor + armorBonus;
    }

    public void IncreaseArmor(int armor)
    {
        armorBonus += armor;

        currentArmor = baseArmor + armorBonus;

        currentArmor = Mathf.Clamp(currentArmor, 0, Mathf.Infinity);
    }

    public void AddStamina(int stamina)
    {
        staminaBonus += stamina;

        currentStamina = baseStamina + staminaBonus;

        currentStamina = Mathf.Clamp(currentStamina, 0, Mathf.Infinity);
    }

    public void ConsumeStamina(int stamina)
    {      

        currentStamina -= stamina;

        currentStamina = Mathf.Clamp(currentStamina, 0, Mathf.Infinity);
    }

    public void RendArmor(int armor)
    {

        currentArmor -= armor;

        currentArmor = Mathf.Clamp(currentArmor, 0, Mathf.Infinity);
    }

    public void SufferDamage(int damage)
    {
        //Damage reduction
        if (damage > currentArmor)
        {
            currentHitpoints += currentArmor - damage;
        }
        

        currentHitpoints = Mathf.Clamp(currentHitpoints, 0, baseHitpoints + hitpointsBonus);

        if (currentHitpoints == 0)
        {
            //Death Logic
        }
    }

    public void Healing(int healing)
    {
        currentHitpoints += healing;

        currentHitpoints = Mathf.Clamp(currentHitpoints, 0, baseHitpoints + hitpointsBonus);
    }
}
