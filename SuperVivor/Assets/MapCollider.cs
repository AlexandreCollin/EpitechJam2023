using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Map"))
        {
            transform.position = transform.position;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
