using UnityEngine;


public class Npc : Actor
{

    [SerializeField] private string _charName;
    public string charName { get { return _charName; } set { _charName = value; } }

    [SerializeField] private int _npcID;
    public int npcID { get { return _npcID; } set { _npcID = value; } }

    [SerializeField] private string _descriptionText;
    public string descriptionText { get { return _descriptionText; } set { _descriptionText = value; } }

    [SerializeField] private string _allQuestsCompleteText;
    public string allQuestsCompleteText { get { return _allQuestsCompleteText; } set { _allQuestsCompleteText = value; } }

    [SerializeField] private bool _hasTalkedWithPlayer = false;
    public bool hasTalkedWithPlayer { get { return _hasTalkedWithPlayer; } set { _hasTalkedWithPlayer = value; } }

    [SerializeField] private bool _isHidden = false;
    public bool isHidden { get { return _isHidden; } set { _isHidden = value; } }


    public SavedNPCData GetSaveData()
    {
        return null;
    }


    public void SetSavedData(SavedNPCData savedNPC)
    {

    }

}