using System.Collections.Generic;


public class GameState
{

    int totalExp;
    public int TotalExp { get { return totalExp; } set { totalExp = value; } }

    int enemiesKilled;
    public int EnemiesKilled { get { return enemiesKilled; } set { enemiesKilled = value; } }

    int totalDamage;
    public int TotalDamage { get { return totalDamage; } set { totalDamage = value; } }

    int moneyCollected;
    public int MoneyCollected { get { return moneyCollected; } set { moneyCollected = value; } }

    int foodCollected;
    public int FoodCollected { get { return foodCollected; } set { foodCollected = value; } }

    int poisoned;
    public int Poisoned { get { return poisoned; } set { poisoned = value; } }

    int trapsTriggered;
    public int TrapsTriggered { get { return trapsTriggered; } set { trapsTriggered = value; } }

    int totalMoves;
    public int TotalMoves { get { return totalMoves; } set { totalMoves = value; } }

    int enemiesCount;
    public int EnemiesCount { get { return enemiesCount; } set { enemiesCount = value; } }

    public List<int> levelsVisited = new List<int>();


    override public string ToString()
    {
        return "";
    }

}