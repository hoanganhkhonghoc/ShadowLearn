using UnityEngine;

// Đối tượng con của hành động tưới cây, gieo hạt
public class DrillsSeed : ActionFather
{

    /* 
     * @function(DoAction) : Hàm con kế thừa từ đối tượng cha
     * 
     */
    public override void DoAction(Animator animator, bool check)
    {
        animator.SetBool("gieo_hat", check);
    }
}