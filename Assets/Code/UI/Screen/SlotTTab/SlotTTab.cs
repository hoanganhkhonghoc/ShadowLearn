using UnityEngine;
using System.Collections;
using TMPro;

public class SlotTTab : MonoBehaviour
{
	public ActionItemsPlayer actionItems;

    public TextMeshProUGUI quanityGo;
    public TextMeshProUGUI quanityHat;
    public TextMeshProUGUI quanityDa;

    private void Start()
    {
        quanityGo.text = "0";
        quanityHat.text = "0";
        quanityDa.text = "0";
    }
    private void Update()
    {
        for(int i=0; i<actionItems.gioiHan.slots.Count; i++)
        {
            if (actionItems.gioiHan.slots[i].type == NameTypeItem.GO)
            {
                if (actionItems.gioiHan.slots[i].count > 0)
                {
                    quanityGo.text = actionItems.gioiHan.slots[i].count.ToString();
                }
                else
                {
                    quanityGo.text = "0";
                }
            }
            if (actionItems.gioiHan.slots[i].type == NameTypeItem.HAT)
            {
                if (actionItems.gioiHan.slots[i].count > 0)
                {
                    quanityHat.text = actionItems.gioiHan.slots[i].count.ToString();
                }
                else
                {
                    quanityHat.text = "0";
                }
            }
            if (actionItems.gioiHan.slots[i].type == NameTypeItem.DA)
            {
                if (actionItems.gioiHan.slots[i].count > 0)
                {
                    quanityDa.text = actionItems.gioiHan.slots[i].count.ToString();
                }
                else
                {
                    quanityDa.text = "0";
                }
            }
        }
    }
}

