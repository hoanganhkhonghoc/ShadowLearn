using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class UseItemsGO : MonoBehaviour
{
    public GameObject GoPreFab;
    public ItemBroad_UI itemBroad_UI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && Check())
        {
            itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].RemoveItem();
            GameObject newObject = Instantiate(GoPreFab, transform.position, UnityEngine.Quaternion.identity);
        }
    }

    private bool Check()
    {
        if(itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].type == NameTypeItem.GO
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