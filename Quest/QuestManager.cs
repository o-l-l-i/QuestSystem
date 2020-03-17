using System.Collections.Generic;
using UnityEngine;


public class QuestManager : MonoBehaviour
{

    public static QuestManager instance = null;

    [SerializeField] private List<Quest> quests = new List<Quest>();

    enum ItemCategory { Consumable, Weapon, Protective, Key, Door, Obstacle, Artifact }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }


    public List<Quest> GetQuests()
    {
        return quests;
    }


    public void AddQuest(Quest quest)
    {
        foreach (Quest findQuest in quests)
        {
            if (findQuest.questID == quest.questID)
            {
                return;
            }
        }
        quests.Add(quest);
    }


    public Quest GetLatestQuest()
    {
        return quests[quests.Count - 1];
    }


    public void RemoveQuest(Quest quest)
    {
        if (quests.Contains(quest))
        {
            quests.Remove(quest);
        }
    }


    public bool IsQuestCompleted(int questID)
    {
        foreach (Quest quest in quests)
        {
            if (quest.questID == questID && quest.status == Quest.Status.Finished)
            {
                return true;
            }
        }
        return false;
    }


    public void AutoCompleteQuest()
    {
        foreach (Quest quest in quests)
        {
            if (quest.status == Quest.Status.InProgress)
            {
                quest.status = Quest.Status.Finished;
                quest.GiveQuestReward();
            }
        }
    }


    public void CheckAllQuestsStatus()
    {
        foreach (Quest quest in quests)
        {
            if (quest.status == Quest.Status.InProgress)
            {
                if (quest.IsQuestPassed())
                {
                    quest.status = Quest.Status.Fulfilled;
                }
            }
            if (quest.status == Quest.Status.Pending)
            {
                foreach (QuestRequirement requirement in quest.requirements)
                {
                    if (requirement.type == QuestRequirement.Type.DungeonLevel)
                    {
                        if (requirement.requirementInt == GameManager.instance.Level)
                        {
                            quest.status = Quest.Status.Unlocked;
                        }
                    }
                }
            }
        }
    }


    public Quest GetLatestQuestForNPC(Npc npc)
    {
        int indexOfHighestID = -1;

        if (quests.Count == 0)
        {
            return null;
        }

        for (int i = 0; i < quests.Count; i++)
        {

            if (quests[i].questOwner == npc.npcID && (quests[i].status != Quest.Status.Finished && quests[i].status != Quest.Status.Pending))
            {
                indexOfHighestID = i;
            }
        }

        if (indexOfHighestID > -1)
        {
            return quests[indexOfHighestID];
        }

        return null;
    }


    public void UnlockQuest(int questID)
    {
        foreach (Quest quest in quests)
        {

            if (quest.questID == questID && quest.status == Quest.Status.Pending)
            {
                quest.status = Quest.Status.Unlocked;
            }
        }
    }


    public void CreateQuests()
    {

        List<QuestRequirement> requirements = new List<QuestRequirement>();

        requirements.Add(new QuestRequirement(QuestRequirement.Type.Exp, 1));
        requirements.Add(new QuestRequirement(QuestRequirement.Type.DungeonLevel, 0));

        List<QuestObjective> objectives = new List<QuestObjective>();

        objectives.Add(new QuestObjective(QuestObjective.Type.KillEnemies, null, 2));
        objectives.Add(new QuestObjective(QuestObjective.Type.GetExperience, null, 4));

        List<QuestReward> rewards = new List<QuestReward>();

        rewards.Add(new QuestReward(QuestReward.Type.Money, null, 50));
        rewards.Add(new QuestReward(QuestReward.Type.UnlockQuest, null, 2));

        Quest quest = new Quest(
                                    questID: 1, questOwner: 1,
                                    questName: "Kill Monsters",
                                    descriptionText: "Hello stranger! This dungeon is infested by monsters. Can you kill two? I will reward your efforts.",
                                    descriptionTextHasMet: "You again. Are you ready to kill monsters now?",
                                    acceptText: "I knew you would help me.",
                                    dontAcceptText: "Too bad. Come back if you change your mind.",
                                    requirementsNotMet: "I need more experienced person for this task! Come back later.",
                                    hintText: "Just go bash a few monster heads in and come back.",
                                    canceledText: "Cancelled.",
                                    completedText: "Well done! Here's 50 gold coins as a reward. ",
                                    status: Quest.Status.Pending,
                                    requirements: requirements,
                                    objectives: objectives,
                                    rewards: rewards
                               );

        AddQuest(quest);

        SortQuests();
    }


    private void SortQuests()
    {
        quests.Sort(delegate (Quest a, Quest b)
        {
            if (a.questID == b.questID) return 0;
            else if (a.questID < b.questID) return 1;
            else if (a.questID > b.questID) return -1;
            else return a.questID.CompareTo(b.questID);
        });
    }


    SavedItemData CreateFakeItem(ItemCategory category, Item.ItemType type)
    {
        SavedItemData saveDataItem = new SavedItemData();
        saveDataItem.itemCategory = category.ToString();
        saveDataItem.itemType = type.ToString();
        saveDataItem.prefabName = type.ToString();
        return saveDataItem;
    }


    public List<SavedQuestData> GetSavedQuestsData()
    {
        List<SavedQuestData> savedQuestData = new List<SavedQuestData>();

        foreach (Quest quest in quests)
        {
            savedQuestData.Add(quest.GetSavedQuestData());
        }
        return savedQuestData;
    }


    public void SetSavedQuestsData(List<SavedQuestData> savedQuests)
    {
        quests.Clear();

        CreateQuests();

        foreach (SavedQuestData savedQuest in savedQuests)
        {

            foreach (Quest quest in quests)
            {

                if (savedQuest.questID == quest.questID)
                {
                    quest.SetSavedQuestData(savedQuest);
                }
            }
        }
    }

}