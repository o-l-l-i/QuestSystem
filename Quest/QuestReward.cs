public class QuestReward
{

    public enum Type { Unknown, Item, Experience, Money, Food, RemoveObstacle, GiveItemToNPC, HideNpcAvatar, UnlockQuest }
    public Type type;

    public SavedItemData rewardItem;

    public int rewardInt;


    public QuestReward(Type type, SavedItemData rewardItem, int rewardInt)
    {
        this.type = type;
        this.rewardItem = rewardItem;
        this.rewardInt = rewardInt;
    }

}