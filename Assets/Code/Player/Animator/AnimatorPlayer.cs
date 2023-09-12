using UnityEngine;

public class AnimatorPlayer : MonoBehaviour
{

    /*
     * @function(Animator)  : Xử lý hình ảnh Animator nhân vật theo x, y transform của nhân vật
     * 
     * @parameter(animator) : Animator nhân vật
     * @parameter(move)     : Vector3 di chuyển xác định x, y
     * 
     */
    public void Animator(Animator animator, Vector3 move)
    {
        if (animator != null)           // Kiểm tra có animator nào không
        {
            if (move.magnitude > 0)     // Kiểm tra có di chuyển hay không
            {
                animator.SetBool("isRunning", true);
                animator.SetFloat("horizontal", move.x);
                animator.SetFloat("vertical", move.y);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }
        }
    }
}