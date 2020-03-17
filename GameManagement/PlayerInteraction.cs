public class PlayerInteraction
{

    GameState gameState;
    Player player;


    public PlayerInteraction(GameState gameState, Player player)
    {
        this.gameState = gameState;
        this.player = player;
    }


    public void ConsumeItem(Item item) { }

    public void ConsumePlayerFood() { }

    public void GivePlayerMoney(int money) { }

    public void GivePlayerExperience(int exp) { }

    public void CheckPlayerExperience() { }

    public void GivePlayerFood(int food) { }

    public void HealPlayer() { }

    public void GivePlayerHealth(int health) { }

    public void GivePlayerAttackDamage(int damage) { }

    public void GivePlayerMoves(int moves) { }

    public void GivePlayerPoisoning(int poisoning) { }

    public void GivePlayerItem(SavedItemData givenItem) { }

    public void GiveItemToNPC(SavedItemData itemToGive, int npcID) { }

    public void DestroyObstacle(SavedItemData obstacle) { }

    public void HideNpcAvatar(int npcID) { }

    public void UseItem(int slotID) { }

}