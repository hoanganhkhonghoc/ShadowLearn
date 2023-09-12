using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    private float time = 0;
    private float maxTime = 30f;

    void Update()
    {
        time += Time.deltaTime;
        if(time >= maxTime) {
            time = 0;
            Destroy(this.gameObject);
        }
    }
}
