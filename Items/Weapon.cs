public class Weapon : Item
{

    new public enum ItemType { Small_Sword, Big_Sword };


    public override void Init() { }


    public override string GetDescription()
    {
        return null;
    }


    public override SavedItemData GetSaveData()
    {
        return null;
    }


    public override void SetSaveData(SavedItemData savedItemData)
    {

    }


    protected override string ItemTypeToString()
    {
        return "";
    }

}