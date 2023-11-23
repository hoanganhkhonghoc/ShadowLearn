using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeMove : MonoBehaviour
{
    Vector3 vector3;
    [SerializeField] private HomeManager homeManager;
    private void Start()
    {
        vector3.x = -344f;
        vector3.y = -144f;
        vector3.z = 0;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && homeManager.check)
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = vector3;
        }
    }
}
