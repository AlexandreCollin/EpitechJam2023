using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;

    Vector2 direction;

    void Start()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z);

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = diff* speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Shoot" && collision.gameObject.tag != "MainCamera")
        {
            Destroy(gameObject);
        }
    }
}
