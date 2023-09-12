using UnityEngine;
using System.Collections;

public class ActionItemsPlayer : MonoBehaviour
{
    public ItemLimit gioiHan;
    private void Awake()
    {
        gioiHan = new ItemLimit(27);
    }
}