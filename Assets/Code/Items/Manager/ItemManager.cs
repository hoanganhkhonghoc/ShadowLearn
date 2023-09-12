using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour
{
    public NameTypeItem type;
    public Sprite icon;
    public Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ActionItemsPlayer tacDongHat = collision.GetComponent<ActionItemsPlayer>();
        if (tacDongHat)
        {
            tacDongHat.gioiHan.Add(this);
            Destroy(this.gameObject);
        }
    }
}

