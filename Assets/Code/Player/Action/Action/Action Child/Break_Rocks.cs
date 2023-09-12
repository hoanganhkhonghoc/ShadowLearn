using UnityEngine;

// Đối tượng con của hành động đập đá
public class Break_Rocks : ActionFather
{

    /* 
     * @function(DoAction) : Hàm con kế thừa từ đối tượng cha
     * 
     */
    public override void DoAction(Animator animator, bool check)
    {
        animator.SetBool("dap_da", check);
    }
}