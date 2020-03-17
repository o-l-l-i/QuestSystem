using System;


[Serializable]
public class SavedItemData
{
    public int levelID;
    public string prefabName;
    public float positionX, positionY;
    public string itemType;
    public string itemName;
    public string itemCategory;
    public int foodValue;
    public int healthValue;
    public int moneyValue;
    public int attackValue;
    public int defenseValue;
    public int range;
    public int baseDurability;
    public int durability;
    public bool hasBeenSeen;
    public bool isEquipped;
    public int belongsToLevel;
    public int targetLevel;
    public float exitCoordX;
    public float exitCoordY;
    public float exitCoordZ;
    public float exitColorR;
    public float exitColorG;
    public float exitColorB;
    public bool isDisabled;


    public SavedItemData()
    {

    }


    public SavedItemData(int levelID, float positionX, float positionY, string itemType, string itemName, string prefabName,
                         string itemCategory, int foodValue, int healthValue, int moneyValue, int attackValue, int defenseValue, int range,
                         int baseDurability, int durability, bool hasBeenSeen)
    {
        this.levelID = levelID;
        this.positionX = positionX;
        this.positionY = positionY;
        this.itemType = itemType;
        this.itemName = itemName;
        this.prefabName = prefabName;
        this.itemCategory = itemCategory;
        this.foodValue = foodValue;
        this.healthValue = healthValue;
        this.moneyValue = moneyValue;
        this.attackValue = attackValue;
        this.defenseValue = defenseValue;
        this.range = range;
        this.baseDurability = baseDurability;
        this.durability = durability;
        this.hasBeenSeen = hasBeenSeen;
    }


    public SavedItemData(int levelID, float positionX, float positionY, string itemType, string itemName, string prefabName,
                         string itemCategory, int attackValue, int defenseValue, int range, int baseDurability, int durability, bool hasBeenSeen)
    {
        this.levelID = levelID;
        this.positionX = positionX;
        this.positionY = positionY;
        this.itemType = itemType;
        this.itemName = itemName;
        this.prefabName = prefabName;
        this.itemCategory = itemCategory;
        this.attackValue = attackValue;
        this.defenseValue = defenseValue;
        this.range = range;
        this.baseDurability = baseDurability;
        this.durability = durability;
        this.hasBeenSeen = hasBeenSeen;
    }


    public SavedItemData(int levelID, float positionX, float positionY, string itemType, string itemName, string prefabName,
                         string itemCategory, int attackValue, int defenseValue, int baseDurability, int durability, bool hasBeenSeen)
    {
        this.levelID = levelID;
        this.positionX = positionX;
        this.positionY = positionY;
        this.itemType = itemType;
        this.itemName = itemName;
        this.prefabName = prefabName;
        this.itemCategory = itemCategory;
        this.attackValue = attackValue;
        this.defenseValue = defenseValue;
        this.baseDurability = baseDurability;
        this.durability = durability;
        this.hasBeenSeen = hasBeenSeen;
    }


    public SavedItemData(int levelID, float positionX, float positionY, string itemType, string itemName, string prefabName,
                         string itemCategory, bool hasBeenSeen)
    {
        this.levelID = levelID;
        this.positionX = positionX;
        this.positionY = positionY;
        this.itemType = itemType;
        this.itemName = itemName;
        this.prefabName = prefabName;
        this.itemCategory = itemCategory;
        this.hasBeenSeen = hasBeenSeen;
    }


    public SavedItemData(int levelID, float positionX, float positionY, string itemType, string itemName, string prefabName,
                         string itemCategory, bool hasBeenSeen, int baseDurability, int durability)
    {
        this.levelID = levelID;
        this.positionX = positionX;
        this.positionY = positionY;
        this.itemType = itemType;
        this.itemName = itemName;
        this.prefabName = prefabName;
        this.itemCategory = itemCategory;
        this.hasBeenSeen = hasBeenSeen;
        this.baseDurability = baseDurability;
        this.durability = durability;
    }


    public SavedItemData(int levelID, float positionX, float positionY, string itemType, string itemName, string prefabName,
                         string itemCategory, bool hasBeenSeen, int belongsToLevel, int targetLevel, float exitCoordX, float exitCoordY, float exitCoordZ,
                         float exitColorR, float exitColorG, float exitColorB, bool isActive)
    {
        this.levelID = levelID;
        this.positionX = positionX;
        this.positionY = positionY;
        this.itemType = itemType;
        this.itemName = itemName;
        this.prefabName = prefabName;
        this.itemCategory = itemCategory;
        this.hasBeenSeen = hasBeenSeen;
        this.belongsToLevel = belongsToLevel;
        this.targetLevel = targetLevel;
        this.exitCoordX = exitCoordX;
        this.exitCoordY = exitCoordY;
        this.exitCoordZ = exitCoordZ;
        this.exitColorR = exitColorR;
        this.exitColorG = exitColorG;
        this.exitColorB = exitColorB;
        this.isDisabled = isActive;
    }


    override public string ToString()
    {
        return "";
    }

}