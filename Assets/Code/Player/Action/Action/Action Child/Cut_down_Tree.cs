using UnityEngine;

// Đối tượng con của hành động chặt cây
public class CutDownTree : ActionFather
{

    /* 
     * @function(DoAction) : Hàm con kế thừa từ đối tượng cha
     * 
     */
    public override void DoAction(Animator animator, bool check)
    {
        animator.SetBool("chat_cay", check);
    }
}