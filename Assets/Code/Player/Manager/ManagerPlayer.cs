using UnityEngine;

public class ManagerPlayer : MonoBehaviour
{

    // Khai báo các thuộc tính unity
    public Animator animator;

    // Khai báo các đối tượng
    public MovePlayer move;
    public ActionPlayerManager actionManager;
    public bool save;

    // Thông tin nhân vật 
    private float speed = 2f;   // Tốc độ nhân vật

    /* 
     * @function(Awake) : Khai báo các lớp đối tượng
     * 
     */
    private void Awake()
    {
        move = GetComponent<MovePlayer>();
        actionManager = GetComponent<ActionPlayerManager>();
    }

    private void Start()
    {
        save = false;
    }
    /*
     * @function(Update)
     * 
     */
    void Update()
    {
        move.Movement(animator, speed);
        actionManager.ProcessActions(animator);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            save = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        save = false;
    }
}