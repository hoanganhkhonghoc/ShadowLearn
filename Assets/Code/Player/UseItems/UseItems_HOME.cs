using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItems_HOME : MonoBehaviour
{
    public GameObject home;
    public ItemBroad_UI itemBroad_UI;
    private bool check = true;
    private Vector3 vector3;
    public Vector3 savePosition;
    private bool Check()
    {
        if (itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].type == NameTypeItem.GO
            && itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].count > 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void Update()
    {
        Debug.Log(itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].type);
        if (Input.GetKeyDown(KeyCode.Y) && Check() && check)
        {
            vector3 = transform.position;
            vector3.y += 6f;
            savePosition = vector3;
            for (int i = 0; i < 2; i++)
            {
                itemBroad_UI.TacDongHat.gioiHan.slots[itemBroad_UI.bling].RemoveItem();
            }
            GameObject newObject = Instantiate(home, vector3, UnityEngine.Quaternion.identity);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        check = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Tree") || collision.gameObject.CompareTag("Land") || collision.gameObject.CompareTag("Fire"))
        {
            check = false;
        }
    }
}
