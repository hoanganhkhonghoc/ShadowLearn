using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuaMove : MonoBehaviour
{
    public UseItems_HOME home;
    public GameObject player;
    private bool check = false;
    private void Update()
    {
        if(check && Input.GetKeyDown(KeyCode.Q))
        {
            player.transform.position = home.savePosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            check = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        check = false;
    }
}
