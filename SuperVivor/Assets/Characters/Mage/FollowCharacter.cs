using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public float speed = 15f;
    public Transform target; // The character that the object will follow
    public float offset = 0.1f; // The offset distance

    void Update()
    {
        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z;

        Vector3 direction = (targetPosition - transform.position).normalized;
        Debug.Log(direction);
        if (Vector3.Distance(targetPosition, transform.position) <= offset)
        {
            animator.SetBool("isAttack", true);
            animator.SetBool("isMoving", false);
        }
        else
        {
            animator.SetBool("isAttack", false);
            animator.SetBool("isMoving", true);
            if (direction.x < 0 && transform.localScale.x != -1)
                transform.localScale = new Vector3(-1, 1, 1);
            else if (direction.x > 0 && transform.localScale.x != 1)
                transform.localScale = new Vector3(1, 1, 1);
            transform.position += direction * speed * Time.deltaTime;
        }

    }
    public Animator animator;
}
