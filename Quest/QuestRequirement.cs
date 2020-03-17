public class QuestRequirement
{

    public enum Type { NoRequirement, QuestCompleted, Money, Exp, EnemiesKilled, DungeonLevel }
    public Type type;

    public int requirementInt;


    public QuestRequirement(Type type, int requirementInt)
    {
        this.type = type;
        this.requirementInt = requirementInt;
    }

}