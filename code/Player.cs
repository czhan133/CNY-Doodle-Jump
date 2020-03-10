using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    public Transform target;
    float movement_speed = 10f;
    float movement = 0.0f;
    Rigidbody2D rigid_body;

    float top_score = 0.0f;
    public Text score_text;

    void Start()
    {
        rigid_body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        movement = Input.GetAxis("Horizontal") * movement_speed;

        if (rigid_body.velocity.y > 0 && target.position.y > top_score)
        {
            top_score = target.position.y;
        }
        score_text.text = "Score: " + Mathf.Round(top_score).ToString();

        if (target.position.y < top_score - 10)
        {
            score_text.text = "";
            SceneManager.LoadScene(2);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rigid_body.velocity;
        velocity.x = movement;
        rigid_body.velocity = velocity; 
    }
}
