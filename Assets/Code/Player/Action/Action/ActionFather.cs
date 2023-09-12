using UnityEngine;

// Lớp Action cha để cho đối tượng phân loại về đối tượng con cần
public abstract class ActionFather : MonoBehaviour
{

    /* 
     * @function(DoAction) : Hàm abstract để các đối tượng con kế thừa
     * 
     */
    public abstract void DoAction(Animator animator, bool check);
}