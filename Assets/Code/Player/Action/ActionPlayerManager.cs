using UnityEngine;

// Lớp ActionManager để quản lý và điều hướng đối tượng
public class ActionPlayerManager : MonoBehaviour
{

    // Khai báo thuộc tính unity 
    public Animator animator;

    // Khai báo các lớp đối tượng
    private ActionFather cutDown;
    private ActionFather drills;
    private ActionFather breakRocks;
    private ActionFather noThing;
    //
    private int status = 0;
    // status = 0 (Không biết làm gì)
    // status = 1 (chặt cây)
    // status = 2 (Đập đá)
    // status = 3 (Tưới )

    //
    public AudioSource audioSource_Cut_Tree;
    public AudioSource audioSource_Pick_Up;

    /* 
     * @function(Awake) : Khai báo các lớp đối tượng
     * 
     */
    private void Awake()
    {
        cutDown    = gameObject.AddComponent<CutDownTree>();
        drills     = gameObject.AddComponent<DrillsSeed>();
        breakRocks = gameObject.AddComponent<Break_Rocks>();
        noThing    = gameObject.AddComponent<NoThing>();
    }

    /* 
     * @function(Action)        : Kết nối tới đối tượng con tương ứng
     * 
     * @parameter(actionFather) : Đối tượng con chuyền vào
     * @parameter(check)        : Animator có chạy hay không 
     * 
     */
    private void Action(ActionFather actionFather, bool check)
    {
        actionFather.DoAction(animator, check);
    }

    /* 
     * @function(ProcessAction) : Gọi lại các hành động
     * 
     * @parameter(animator)     : Animator nhân vật
     * 
     */
    public void ProcessActions(Animator animator)
    {
        ActionKeyF();
    }

    /* 
     * @function(CutDownTreeAction) : Hành động chặt cây (Animator)
     * 
     */
    private void ActionKeyF()
    {
        bool checkKeyF = Input.GetKey(KeyCode.F);
        switch (status)
        {
            case 0:
                Action(noThing, checkKeyF);
                break;
            case 1:
                Action(cutDown, checkKeyF);
                break;
            case 2:
                Action(breakRocks, checkKeyF);
                break;
            case 3:
                //Action(drills, checkKeyF);
                break;
        }
        if (checkKeyF && status == 1) { audioSource_Cut_Tree.mute = false; } else { audioSource_Cut_Tree.mute = true; }
        if(checkKeyF && status == 3) { audioSource_Pick_Up.mute = false; } else { audioSource_Pick_Up.mute = true; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Tree"))
        {
            status = 1;
        }
        if (collision.gameObject.CompareTag("Rock"))
        {
            status = 2;
        }
        if (collision.gameObject.CompareTag("Land"))
        {
            status = 3;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        status = 0;
    }
}