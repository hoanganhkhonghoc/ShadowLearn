using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemManager : MonoBehaviour
{
    public ItemManager[] collec;
    private Dictionary<NameTypeItem, ItemManager> collectableItemDict = new Dictionary<NameTypeItem, ItemManager>();
    private void Awake()
    {
        foreach (ItemManager item in collec)
        {
            AddItem(item);
        }
    }
    private void AddItem(ItemManager item)
    {
        if (!collectableItemDict.ContainsKey(item.type))
        {
            collectableItemDict.Add(item.type, item);
        }
    }
    public ItemManager GetItemType(NameTypeItem type)
    {
        if (collectableItemDict.ContainsKey(type))
        {
            return collectableItemDict[type];
        }
        return null;
    }
}

