using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeManager : MonoBehaviour
{
    public GameObject keyQ;
    public bool check;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            keyQ.SetActive(true);
            check = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        keyQ.SetActive(false);
        check = false;
    }
    private void Start()
    {
        check = false;
    }
}
