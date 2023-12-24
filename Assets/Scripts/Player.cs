using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Player : MonoBehaviour
{
    private Vector2 movement;

    public float speed = 5f;
    public float delay = .1f;

    void Start()
    {
        Rigidbody2D rig = gameObject.GetComponent<Rigidbody2D>();
        rig.gravityScale = 0f;
    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(inputX, inputY);

        transform.Translate(movement * speed * Time.deltaTime);
    }

}
