using UnityEngine;

public class ManagerTree : MonoBehaviour
{
    public GameObject preFab;
    public Animator animator;

    public int status;

    private bool checkPlayer;
    private bool life;
    private bool timeStart;
    private int cout;
    private float time;
    private Vector3 vector3;

    private void Start()
    {
        animator = GetComponent<Animator>();
        checkPlayer = false;
        cout = 0;
        life = true;
        timeStart = false;
        time = 0;
        vector3 = transform.position;
        vector3.y += 2f;
        status = 1;
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
    private void Update()
    {
        if(checkPlayer && Input.GetKey(KeyCode.F) && life)
        {
            time = 0;
            cout++;
        }
        if(cout == 1000)
        {
            life = false;
            animator.SetBool("die", true);
            timeStart = true;
            GameObject game = Instantiate(preFab, vector3, Quaternion.identity);
            gameObject.tag = "none";
            status = 0;
        }
        if (timeStart)
        {
            time += Time.deltaTime;
            cout = 0;
        }
        if(time >= 90f)
        {
            life = true;
            timeStart = false;
            animator.SetBool("die", false);
            gameObject.tag = "Tree";
            status = 1;
        }
    }
}