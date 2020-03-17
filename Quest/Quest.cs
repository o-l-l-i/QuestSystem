using System.Collections.Generic;


public class Quest
{

    public int questID;
    public int questOwner;
    public string questName;
    public string descriptionText;
    public string descriptionTextHasMet;
    public string acceptText;
    public string dontAcceptText;
    public string requirementsNotMetText;
    public string hintText;
    public string canceledText;
    public string completedText;

    public enum Status { Pending, Unlocked, InProgress, Fulfilled, Finished, Cancelled }
    public Status status;

    public List<QuestRequirement> requirements;
    public List<QuestObjective> objectives;
    public List<QuestReward> rewards;


    public Quest(int questID, int questOwner, string questName,
                 string descriptionText, string descriptionTextHasMet,
                 string acceptText, string dontAcceptText, string requirementsNotMet,
                 string hintText, string canceledText, string completedText,
                 Status status,
                 List<QuestRequirement> requirements,
                 List<QuestObjective> objectives,
                 List<QuestReward> rewards)
    {
        this.questID = questID;
        this.questOwner = questOwner;
        this.questName = questName;
        this.descriptionText = descriptionText;
        this.descriptionTextHasMet = descriptionTextHasMet;
        this.acceptText = acceptText;
        this.dontAcceptText = dontAcceptText;
        this.requirementsNotMetText = requirementsNotMet;
        this.hintText = hintText;
        this.canceledText = canceledText;
        this.completedText = completedText;
        this.status = status;
        this.requirements = requirements;
        this.objectives = objectives;
        this.rewards = rewards;
    }


    public void InitQuest()
    {
        foreach (QuestObjective objective in this.objectives)
        {

            if (objective.type == QuestObjective.Type.KillEnemies)
            {
                objective.objectiveIntB = GameManager.instance.gameState.EnemiesKilled;
            }
            else if (objective.type == QuestObjective.Type.KillAllEnemiesOnLevel)
            {
                objective.objectiveInt = GameManager.instance.gameState.EnemiesCount;
            }

            else if (objective.type == QuestObjective.Type.GetExperience)
            {
                objective.objectiveIntB = GameManager.instance.player.stats.exp;
            }

            else if (objective.type == QuestObjective.Type.GetFood)
            {
                objective.objectiveIntB = GameManager.instance.gameState.FoodCollected;
            }

            else if (objective.type == QuestObjective.Type.GetMoney)
            {
                objective.objectiveIntB = GameManager.instance.gameState.MoneyCollected;
            }

            else if (objective.type == QuestObjective.Type.GetItem)
            {
                objective.objectiveIntB = 0;
            }

            else if (objective.type == QuestObjective.Type.BringItem)
            {
                objective.objectiveIntB = 0;
            }
        }
    }


    public bool CheckRequirements()
    {
        bool finalValue = true;
        List<bool> requirementsOk = new List<bool>();

        foreach (QuestRequirement requirement in requirements)
        {

            if (requirement.type == QuestRequirement.Type.NoRequirement)
            {
                requirementsOk.Add(true);
            }

            else if (requirement.type == QuestRequirement.Type.Money)
            {
                if (GameManager.instance.player.stats.money >= requirement.requirementInt)
                    requirementsOk.Add(true);
                else
                    requirementsOk.Add(false);
            }

            else if (requirement.type == QuestRequirement.Type.Exp)
            {
                if (GameManager.instance.player.stats.exp >= requirement.requirementInt)
                    requirementsOk.Add(true);
                else
                    requirementsOk.Add(false);
            }

            else if (requirement.type == QuestRequirement.Type.EnemiesKilled)
            {
                if (GameManager.instance.gameState.EnemiesKilled >= requirement.requirementInt)
                    requirementsOk.Add(true);
                else
                    requirementsOk.Add(false);
            }

            else if (requirement.type == QuestRequirement.Type.DungeonLevel)
            {
                if (GameManager.instance.Level == requirement.requirementInt)
                    requirementsOk.Add(true);
                else
                    requirementsOk.Add(false);
            }

            else if (requirement.type == QuestRequirement.Type.QuestCompleted)
            {

                if (QuestManager.instance.IsQuestCompleted(requirement.requirementInt))
                    requirementsOk.Add(true);
                else
                    requirementsOk.Add(false);
            }
        }

        foreach (bool value in requirementsOk)
        {
            if (value == false)
            {
                finalValue = false;
            }
        }

        if (finalValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public bool IsQuestPassed()
    {
        bool finalValue = true;
        List<bool> objectivesOk = new List<bool>();

        foreach (QuestObjective objective in this.objectives)
        {

            if (objective.type == QuestObjective.Type.KillEnemies)
            {

                if (GameManager.instance.gameState.EnemiesKilled >= objective.objectiveInt + objective.objectiveIntB)
                {
                    objectivesOk.Add(true);
                }
                else
                {
                    objectivesOk.Add(false);
                }
            }

            if (objective.type == QuestObjective.Type.KillAllEnemiesOnLevel)
            {

                if (GameManager.instance.gameState.EnemiesCount > 0)
                {
                    objectivesOk.Add(false);
                }
                else
                {
                    objectivesOk.Add(true);
                }
            }

            if (objective.type == QuestObjective.Type.GetFood)
            {

                if (GameManager.instance.gameState.FoodCollected >= objective.objectiveInt + objective.objectiveIntB)
                {
                    objectivesOk.Add(true);
                }
                else
                {
                    objectivesOk.Add(false);
                }
            }

            if (objective.type == QuestObjective.Type.GetMoney)
            {

                if (GameManager.instance.gameState.MoneyCollected >= objective.objectiveInt + objective.objectiveIntB)
                {
                    objectivesOk.Add(true);
                }
                else
                {
                    objectivesOk.Add(false);
                }
            }

            if (objective.type == QuestObjective.Type.GetExperience)
            {

                if (GameManager.instance.player.stats.exp >= objective.objectiveInt + objective.objectiveIntB)
                {
                    objectivesOk.Add(true);
                }
                else
                {
                    objectivesOk.Add(false);

                }
            }

            if (objective.type == QuestObjective.Type.GetItem)
            {

                if (GameManager.instance.player.inventory.HasItem(objective.objectiveItem))
                {
                    objectivesOk.Add(true);
                }
                else
                {
                    objectivesOk.Add(false);
                }
            }

            if (objective.type == QuestObjective.Type.BringItem)
            {

                if (GameManager.instance.player.inventory.HasItem(objective.objectiveItem))
                {
                    objectivesOk.Add(true);
                }
                else
                {
                    objectivesOk.Add(false);
                }
            }
        }

        foreach (bool value in objectivesOk)
        {
            if (value == false)
            {
                finalValue = false;
            }
        }

        if (finalValue)
        {
            return true;
        }

        return false;
    }


    public int CheckProgress(QuestObjective objective)
    {
        if (status == Status.InProgress || status == Status.Fulfilled || status == Status.Finished)
        {
            int index = objectives.IndexOf(objective);
            int objectiveIntB = objectives[index].objectiveIntB;

            if (objective.type == QuestObjective.Type.KillEnemies)
            {
                return GameManager.instance.gameState.EnemiesKilled - objectiveIntB;
            }

            else if (objective.type == QuestObjective.Type.KillAllEnemiesOnLevel)
            {
                int enemiesCount = GameManager.instance.gameState.EnemiesCount;
                if (enemiesCount >= 0)
                {
                    return objective.objectiveInt - enemiesCount;
                }
            }

            else if (objective.type == QuestObjective.Type.GetExperience)
            {
                return GameManager.instance.player.stats.exp - objectiveIntB;
            }

            else if (objective.type == QuestObjective.Type.GetFood)
            {
                return GameManager.instance.gameState.FoodCollected - objectiveIntB;
            }

            else if (objective.type == QuestObjective.Type.GetMoney)
            {
                return GameManager.instance.gameState.MoneyCollected - objectiveIntB;
            }

            else if (objective.type == QuestObjective.Type.GetItem)
            {
                if (GameManager.instance.player.inventory.HasItem(objective.objectiveItem))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            else if (objective.type == QuestObjective.Type.BringItem)
            {
                if (GameManager.instance.player.inventory.HasItem(objective.objectiveItem))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        return 0;
    }


    public void CompleteQuest()
    {
        if (IsQuestPassed())
        {
            status = Status.Finished;
            GiveQuestReward();
        }
    }


    public void GiveQuestReward()
    {
        foreach (QuestReward reward in this.rewards)
        {
            if (reward.type == QuestReward.Type.Money)
            {
                GameManager.instance.playerInteraction.GivePlayerMoney(reward.rewardInt);
            }

            else if (reward.type == QuestReward.Type.Experience)
            {
                GameManager.instance.playerInteraction.GivePlayerExperience(reward.rewardInt);
            }

            else if (reward.type == QuestReward.Type.Food)
            {
                GameManager.instance.playerInteraction.GivePlayerFood(reward.rewardInt);
            }

            else if (reward.type == QuestReward.Type.Item)
            {
                GameManager.instance.playerInteraction.GivePlayerItem(reward.rewardItem);
            }

            else if (reward.type == QuestReward.Type.UnlockQuest)
            {
                QuestManager.instance.UnlockQuest(reward.rewardInt);
            }

            else if (reward.type == QuestReward.Type.HideNpcAvatar)
            {
                GameManager.instance.playerInteraction.HideNpcAvatar(reward.rewardInt);
            }

            else if (reward.type == QuestReward.Type.RemoveObstacle)
            {
                GameManager.instance.playerInteraction.DestroyObstacle(reward.rewardItem);
            }

            else if (reward.type == QuestReward.Type.GiveItemToNPC)
            {
                GameManager.instance.playerInteraction.GiveItemToNPC(reward.rewardItem, reward.rewardInt);
            }
        }
    }


    public SavedQuestData GetSavedQuestData()
    {
        SavedQuestData savedQuestData = new SavedQuestData(questID, questOwner, status, objectives);
        return savedQuestData;
    }


    public void SetSavedQuestData(SavedQuestData savedQuestData)
    {
        status = savedQuestData.questStatus;
        objectives = savedQuestData.objectives;
    }


    override public string ToString()
    {
        return "";
    }

}