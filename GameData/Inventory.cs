public class Inventory
{

    private Actor owner;
    public Actor Owner { get { return owner; } }

    public SavedItemData[] inventory;


    public Inventory(Actor owner, int capacity)
    {
        this.owner = owner;
        inventory = new SavedItemData[capacity];
    }


    public SavedItemData[] Get()
    {
        return this.inventory;
    }


    public void Set(SavedItemData[] inventory)
    {
        this.inventory = inventory;
    }


    public SavedItemData GetSlot(int slotID)
    {
        if (inventory[slotID] == null)
            return null;
        else
            return inventory[slotID];
    }


    public bool AddItemToInventory(Item item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = (item.GetSaveData());
                return true;
            }
            else if (string.IsNullOrEmpty(inventory[i].prefabName))
            {
                inventory[i] = (item.GetSaveData());
                return true;
            }
        }
        return false;
    }


    public void RemoveItemFromInventory(int slotID)
    {
        inventory[slotID] = null;
    }


    public void RemoveItemFromInventory(Item item)
    {
        int index = HasItemTypeAtIndex(item);
        if (index > -1)
        {
            RemoveItemFromInventory(index);
        }
    }


    public void RemoveItemFromInventory(SavedItemData sItem)
    {

    }


    public bool HasItem(Item itemCompare)
    {
        return false;
    }


    public bool HasItem(SavedItemData itemCompare)
    {
        return false;
    }


    public int HasItemTypeAtIndex(Item item)
    {
        return -1;
    }

}