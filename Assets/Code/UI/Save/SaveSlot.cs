using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSlot : MonoBehaviour
{
    [SerializeField] private ActionItemsPlayer TacDongHat;
    private List<SlotItem> slotItems = new List<SlotItem>();

    [SerializeField] private TextAsset fileSave;
    
    public void SaveItem()
    {
        for(int i = 0; i < TacDongHat.gioiHan.slots.Count; i++)
        {
            slotItems.Add(TacDongHat.gioiHan.slots[i]);
        }
        string filePath = Application.dataPath + "/Code/UI/Save/Slot.txt";
        string slotData = "";
        foreach (SlotItem item in slotItems)
        {
            slotData += item.ToString() + "\n";
        }

        Debug.Log(filePath);
        File.WriteAllText(filePath, "");
        File.WriteAllText(filePath, slotData);
        Debug.Log("Dữ liệu đã được lưu vào tệp tin: " + filePath);
    }
}
