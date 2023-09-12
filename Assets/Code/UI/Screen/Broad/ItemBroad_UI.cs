using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class ItemBroad_UI : MonoBehaviour
{
    public ActionItemsPlayer TacDongHat;
    public List<Slot_UI> slot_UIs = new List<Slot_UI>();
    public List<GameObject> che = new List<GameObject>();
    public int bling = 0;
    private void Update()
    {
        SetUp();
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            bling--;
            if (bling < 0)
            {
                bling = 6;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            bling++;
            if (bling > 6)
            {
                bling = 0;
            }
        }
        BlingItem();
        GetKey();
    }
    private void SetUp()
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
    private void BlingItem()
    {
        for (int i = 0; i < slot_UIs.Count; i++)
        {
            if (i == bling)
            {
                che[i].SetActive(false);
            }
            else
            {
                che[i].SetActive(true);
            }
        }
    }
    private void GetKey()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            bling = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            bling = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            bling = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            bling = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            bling = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            bling = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            bling = 6;
        }
    }
}

