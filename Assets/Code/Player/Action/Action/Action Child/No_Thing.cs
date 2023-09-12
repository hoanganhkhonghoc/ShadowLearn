using UnityEngine;

// Đối tượng con của hành động không làm gì
public class NoThing : ActionFather
{

    /* 
     * @function(DoAction) : Hàm con kế thừa từ đối tượng cha
     * 
     */
    public override void DoAction(Animator animator, bool check)
    {
        animator.SetBool("khong_lam_gi", check);
    }
}