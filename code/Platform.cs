using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jump_force = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rigid_body = collision.collider.GetComponent<Rigidbody2D>();

            if (rigid_body != null)
            {
                Vector2 velocity = rigid_body.velocity;
                velocity.y = jump_force;
                rigid_body.velocity = velocity;
            }
        }
    }
}
