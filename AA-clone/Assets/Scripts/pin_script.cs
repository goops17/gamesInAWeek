using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin_script : MonoBehaviour
{
    bool fire = false;
    bool collisionWithRotator = false;
    float speed = 20f;
    private Rigidbody2D rb;

    // Update is called once per frame
    private void Start()
    {
        rb= this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (!collisionWithRotator)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag== "center_circle")
        {
            Debug.Log("in");
            transform.SetParent(collision.transform);
            collisionWithRotator = true;
        }
    }
}
