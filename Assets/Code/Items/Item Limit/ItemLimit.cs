using System.Collections.Generic;

[System.Serializable]
public class ItemLimit
{
    public List<SlotItem> slots = new List<SlotItem>();

    public ItemLimit(int numberSlotsItems)
    {
        for (int i = 0; i < numberSlotsItems; i++)
        {
            SlotItem slot = new SlotItem();
            slots.Add(slot);
        }
    }

    public void Add(ItemManager item)
    {
        foreach (SlotItem slot in slots)
        {
            if (slot.type == item.type && slot.CanAdd())
            {
                slot.AddItems(item);
                return;
            }
        }

        foreach (SlotItem slot in slots)
        {
            if (slot.type == NameTypeItem.NONE)
            {
                slot.AddItems(item);
                return;
            }
        }
    }

    public void Remove(int index)
    {
        slots[index].RemoveItem();
    }

    public void UseItems(int index)
    {
        slots[index].RemoveItem();
    }
}