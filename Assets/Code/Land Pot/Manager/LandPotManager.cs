using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class LandPotManager : MonoBehaviour
{
    public GameObject tree_item;

    public GameObject item_HAT;
    public GameObject item_BANH_MI_S;
    public GameObject item_BANH_MI_A;
    public GameObject item_BANH_MI_D;
    public GameObject item_PHO_MAI_S;

    public bool checkPlayer;

    private bool check = false;
    private float time = 0f;

    private GameObject final;
    private bool checkS = false;
    int i = 0;
    public GameObject RandomSelectItem()
    {
        float randomValue = Random.Range(0f, 100f);
        if (randomValue < 2.5f)
        {
            return item_BANH_MI_S;
        }
        else if (randomValue < 5f)
        {
            return item_PHO_MAI_S;
        }
        else if (randomValue < 20f)
        {
            return item_BANH_MI_A;
        }
        else if(randomValue < 50f)
        {
            return item_HAT;
        }
        else
        {
            return item_BANH_MI_D;
        }
    }
    private void Update()
    {
        time += Time.deltaTime;
        if(i == 0)
        {
            final = RandomSelectItem();
            if (RandomSelectItem() == item_BANH_MI_S || RandomSelectItem() == item_PHO_MAI_S)
            {
                checkS = true;
            }
        }
        i++;
        if(time >= 120)
        {
            check = true;
            tree_item.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.F) && checkPlayer && check)
        {
            i = 0;
            time = 0;
            check = false;
            GameObject game = Instantiate(final, transform.position, UnityEngine.Quaternion.identity);
            if(checkS == false)
            {
                GameObject game1 = Instantiate(item_HAT, transform.position, UnityEngine.Quaternion.identity);
            }
            checkS = false;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            checkPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        checkPlayer = false;   
    }
}
