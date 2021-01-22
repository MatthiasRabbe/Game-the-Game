using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questlog : MonoBehaviour
{

    public List<Quest> questList;

    private Stats playerStats;

    public InventoryManager playerInventory;


    public void Start()
    {
        //Required the GameObject called "Player" to have the Stats script attach
        playerStats = GameObject.Find("Player").GetComponent<Stats>();
    }


    public void CheckAddProgress(GameObject possibleGoal)
    {
        //Quest handling
        for (int i =0; i < questList.Count; i++)
        {

            var currentQuestGoals = questList[i].GetGoals();
            //Goal handling
            for (int j = 0; j < questList[i].GetGoals().Count; j++)
            {
                var currentGoal = questList[i].GetGoals()[j];

                //Checks if the item/monster  we just picked up/ destroyed contains the string we need for our goal
                if (possibleGoal.name.Contains(currentGoal.goal.name) && currentGoal.goalType != Goal.GoalType.Find)
                {
                    currentGoal.QuestAddProgress(1);
                    questList[i].CheckQuestStatus();


                    break;

                }

                //Case: When the Goal ist a Find - Find Goals should have no GameOBject as a goal, but corrdinates
                if (possibleGoal == null && currentGoal.goalType == Goal.GoalType.Find)
                {
                    currentGoal.completed = true;
                    questList[i].CheckQuestStatus();
                    break;
                }

            }

        }

    }

    public void GrantRewards(int gold, int xP, List<Item> items, Quest quest, bool resetQuest)
    {
        bool successful = false;

        if (items.Count >= 0 && items != null)
        {

            foreach (var newItem in items)
            {
                if (playerInventory.AddItem(newItem, 1))
                {
                    successful = true;
                }
                else
                {
                    successful = false;
                    Debug.Log("You must make space in your inventory before you can complete this quest");
                    break;
                }
            }
        }
        else
        {
            successful = true;
        }

        if (successful)
        {
            playerStats.gold += gold;
            playerStats.AddExperience(xP);
            RemoveQuestFromLog(quest, resetQuest);
        }
    }

    public void RemoveQuestFromLog(Quest quest, bool resetQuest)
    {

        if (resetQuest)
        {
            quest.ResetQuest();
        }

        questList.Remove(quest);
    }
}
