using UnityEngine;


public abstract class Item : MonoBehaviour
{

    public enum ItemType { None };

    [SerializeField] private int _foodValue;
    public int foodValue { get { return _foodValue; } set { _foodValue = value; } }

    [SerializeField] private int _healthValue;
    public int healthValue { get { return _healthValue; } set { _healthValue = value; } }

    [SerializeField] private int _moneyValue;
    public int moneyValue { get { return _moneyValue; } set { _moneyValue = value; } }

    [SerializeField] private int _attackValue;
    public int attackValue { get { return _attackValue; } set { _attackValue = value; } }

    [SerializeField] private int _defenseValue;
    public int defenseValue { get { return _defenseValue; } set { _defenseValue = value; } }

    [SerializeField] private int _range;
    public int range { get { return _range; } set { _range = value; } }

    [SerializeField] private int _baseDurability;
    public int baseDurability { get { return _baseDurability; } set { _baseDurability = value; } }

    [SerializeField] private int _durability;
    public int durability { get { return _durability; } set { _durability = value; } }

    [SerializeField] private string _itemName;
    public string itemName { get { return _itemName; } set { _itemName = value; } }

    [SerializeField] private string _itemCategory;
    public string itemCategory { get { return _itemCategory; } set { _itemCategory = value; } }

    [SerializeField] private string _prefabName;
    public string prefabName { get { return _prefabName; } set { _prefabName = value; } }

    [SerializeField] private float _positionX;
    public float positionX { get { return _positionX; } set { _positionX = value; } }

    [SerializeField] private float _positionY;
    public float positionY { get { return _positionY; } set { _positionY = value; } }

    [SerializeField] private bool _hasBeenSeen;
    public bool hasBeenSeen { get { return _hasBeenSeen; } set { _hasBeenSeen = value; } }


    public abstract void Init();

    public abstract string GetDescription();

    public abstract SavedItemData GetSaveData();

    public abstract void SetSaveData(SavedItemData savedItemData);

    protected abstract string ItemTypeToString();

}