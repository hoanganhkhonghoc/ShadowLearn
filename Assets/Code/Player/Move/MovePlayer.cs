using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    // Khai báo lớp đối tượng
    public AnimatorPlayer animatorPlayer;

    /* 
     * @fuction(Movement)   : di chuyển nhân vật theo hướng Horizontal (A, D), Vertical (S, W)
     * 
     * @parameter(animator) : Animator của nhân vật mục tiêu chuyền sang đối animatorPlayer để xử lý chuyển Animator
     * @parameter(speed)    : tốc độ di chuyển của nhân vật
     * 
     */
    public void Movement(Animator animator, float speed)
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(horizontal, vertical);

        // Nhân vật di chuyển theo công thức : hướng x tốc độ nhân vật x thời gian
        transform.position += move * speed * Time.deltaTime;

        // Xử lý Animator theo hướng di chuyển
        animatorPlayer.Animator(animator, move);
    }
}