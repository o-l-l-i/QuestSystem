public class PlayerStats
{

    public int health = 100;
    public int maxHealth = 100;
    public int food = 100;
    public int money = 0;
    const float xpConst = 0.2f;
    public float XpConst { get { return xpConst; } }
    public int exp = 0;
    public int expLevel = 1;
    int defaultAtk = 10;
    public int DefaultAtk { get { return defaultAtk; } }
    int defaultDef = 5;
    public int DefaultDef { get { return defaultDef; } }
    public int atk;
    public int def;
    public int healingRate = 4;
    public int healingCounter = 0;
    public int hungerRate = 4;
    public int hungerCounter = 0;
    public int waitCounter = 0;
    const int capacity = 5;
    public int defaultMoves = 3;
    public int moves = 3;


    override public string ToString()
    {
        return "";
    }

}