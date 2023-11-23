using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloesManager_UI : MonoBehaviour
{
    [SerializeField] private GameObject background_Setting;
    public void Open_Setting()
    {
        background_Setting.SetActive(true);
    }
    public void Close_Settign()
    {
        background_Setting.SetActive(false);
    }
}
