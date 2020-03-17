public class QuestObjective
{

    public enum Type { KillEnemies, KillAllEnemiesOnLevel, GetItem, BringItem, GetExperience, GetFood, GetMoney }
    public Type type;

    public SavedItemData objectiveItem;

    public int objectiveInt;
    public int objectiveIntB;

    public QuestObjective(Type type, SavedItemData objectiveItem, int objectiveInt)
    {
        this.type = type;
        this.objectiveItem = objectiveItem;
        this.objectiveInt = objectiveInt;
    }

}