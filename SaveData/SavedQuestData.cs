using System.Collections.Generic;
using System;


[Serializable]
public class SavedQuestData
{

    public int questID;
    public int questOwner;
    public Quest.Status questStatus;
    public List<QuestObjective> objectives;


    public SavedQuestData(int questID, int questOwner, Quest.Status questStatus, List<QuestObjective> objectives)
    {
        this.questID = questID;
        this.questOwner = questOwner;
        this.questStatus = questStatus;
        this.objectives = objectives;
    }

}