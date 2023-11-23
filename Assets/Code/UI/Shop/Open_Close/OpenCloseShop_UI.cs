using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseShop_UI : MonoBehaviour
{
    [SerializeField] private GameObject background_Shop;
    public void Open_Setting()
    {
        background_Shop.SetActive(true);
    }
    public void Close_Settign()
    {
        background_Shop.SetActive(false);
    }
}
