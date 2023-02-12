using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rb;

    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = (Input.mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x, direction.y);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("ZIZI"))
        {
            Debug.Log("HIT BOY");
            Destroy(gameObject);
        }
    }
}
