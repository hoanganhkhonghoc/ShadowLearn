using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemsHAT : MonoBehaviour
{
    public GameObject TreePreFab;
    public ItemBroad_UI itemBroad_UI;
    private bool check = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && Check() && check)
        {
            itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].RemoveItem();
            GameObject newObject = Instantiate(TreePreFab, transform.position, UnityEngine.Quaternion.identity);
        }
    }

    private bool Check()
    {
        Debug.Log(itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].type);
        if (itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].type == NameTypeItem.HAT
            && itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Tree") || collision.gameObject.CompareTag("Land") || collision.gameObject.CompareTag("Fire"))
        {
            check = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        check = true;
    }
}
