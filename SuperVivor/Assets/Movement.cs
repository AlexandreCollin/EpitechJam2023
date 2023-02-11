using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{



    void Start()
    {
        
    }

    void Update()
    {
        animator.SetBool("isMoving", false);
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isMoving", true);
            transform.Translate(Vector2.right * velocity * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 1) * scale;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("isMoving", true);
            transform.Translate(Vector2.left * velocity * Time.deltaTime);
            transform.localScale= new Vector3(-1, 1, 1) * scale;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("isMoving", true); ;
            transform.Translate(Vector2.up * velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isMoving", true);
            transform.Translate(Vector2.down * velocity * Time.deltaTime);
        }
    }

    public float scale = 1f;
    public float velocity = 3.0f;
    public Animator animator;
}
