using UnityEngine;


public class GameManager : MonoBehaviour
{

    private int level = 0;
    public int Level
    {
        get { return level; }
        set { level = value; }
    }


    private Player _player;
    public Player player { get { return _player; } set { _player = value; } }


    public static GameManager instance = null;

    public GameState gameState = new GameState();

    public PlayerInteraction playerInteraction;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)

            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

}