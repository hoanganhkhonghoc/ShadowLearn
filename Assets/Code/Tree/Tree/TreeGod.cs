using UnityEngine;
using System.Collections.Generic;

public class TreeGod : MonoBehaviour
{
    public List<ManagerTree> treeManagers = new List<ManagerTree>();
    public List<GameObject> treePrefabs = new List<GameObject>();
    private int cout;
    public float moveSpeed = 4f;
    public float minDistanceToPlayer = 8f;
    private GameObject player;
    public AudioSource soud;
    void Start()
    {
        cout = 0;
        if (treePrefabs.Count != 7)
        {
            return;
        }

        foreach (var prefab in treePrefabs)
        {
            ManagerTree treeManager = prefab.GetComponent<ManagerTree>();
            treeManagers.Add(treeManager);
        }
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        foreach (var manager in treeManagers)
        {
            if (manager.status == 0)
            {
                cout++;
            }
        }

        if (cout > 6 && player != null)
        {
            Vector3 directionToPlayer = player.transform.position - transform.position;
            float distanceToPlayer = directionToPlayer.magnitude;
            if (distanceToPlayer > minDistanceToPlayer)
            {
                Vector3 moveDirection = directionToPlayer.normalized;
                transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
                soud.mute = false;
            }
        }

        if (cout < 6)
        {
            cout = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            Debug.Log("END Game");
        }
    }
}
