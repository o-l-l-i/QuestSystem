using System;


[Serializable]
public class SavedNPCData
{

    public int levelID;
    public string charName;
    public int npcID;
    public bool hasTalkedWithPlayer;
    public bool isHidden;


    public SavedNPCData(int levelID, string charName, int npcID, bool hasTalkedWithPlayer, bool isHidden)
    {
        this.levelID = levelID;
        this.charName = charName;
        this.npcID = npcID;
        this.hasTalkedWithPlayer = hasTalkedWithPlayer;
        this.isHidden = isHidden;
    }

}