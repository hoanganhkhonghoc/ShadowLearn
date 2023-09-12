using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BANH_MI_A : MonoBehaviour
{
    public ItemBroad_UI itemBroad_UI;
    public StatusPlayer player;
    private void Update()
    {
        Debug.Log(Check());
        Debug.Log(itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].type);
        if (Input.GetKeyDown(KeyCode.T) && Check())
        {
            itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].RemoveItem();
            player.mana += 300f;
        }
    }

    private bool Check()
    {
        if (itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].type == NameTypeItem.BANH_MI_B
            && itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
