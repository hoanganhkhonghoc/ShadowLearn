using UnityEngine;

[System.Serializable]
public class SlotItem
{
    public NameTypeItem type;
    public int count;
    public int max;
    public Sprite icon;

    public SlotItem()
    {
        type = NameTypeItem.NONE;
        count = 0;
        max = 100;
    }

    public bool CanAdd()
    {
        if (count < max)
        {
            return true;
        }
        return false;
    }

    public void AddItems(ItemManager item)
    {
        this.type = item.type;
        this.icon = item.icon;
        count++;
    }

    public void RemoveItem()
    {
        if (count > 0)
        {
            count--;
            if (count == 0)
            {
                icon = null;
                type = NameTypeItem.NONE;
            }
        }
    }
}