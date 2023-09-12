using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPlayer : MonoBehaviour
{
    public Image fill;

    public void UpdateBar(float curenValue, float maxValue)
    {
        fill.fillAmount = curenValue / maxValue;
    }
    public float mana;
    private float max = 500f;
    private void Start()
    {
        mana = 500f;
    }
    private void Update()
    {
        if(mana < 0)
        {
            Debug.Log("Die");
            Time.timeScale = 0f;
        }
        else
        {
            mana -= Time.deltaTime;
            UpdateBar(mana, max);
        }
        if(mana > max)
        {
            mana = max;
        }
    }
}