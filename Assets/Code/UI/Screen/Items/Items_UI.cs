using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items_UI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public ActionItemsPlayer TacDongHat;
    public List<Slot_UI> slot_UIs = new List<Slot_UI>();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInventory();
        }
    }
    public void ToggleInventory()
    {
        if (!inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(true);
            Setup();
        }
        else
        {
            inventoryPanel.SetActive(false);
        }
    }
    void Setup()
    {
        if (slot_UIs.Count == TacDongHat.gioiHan.slots.Count)
        {
            for (int i = 0; i < slot_UIs.Count; i++)
            {
                if (TacDongHat.gioiHan.slots[i].type != NameTypeItem.NONE)
                {
                    slot_UIs[i].SetItem(TacDongHat.gioiHan.slots[i]);
                }
                else
                {
                    slot_UIs[i].SetEmpty();
                }
            }
        }
    }
}

