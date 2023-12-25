using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

[RequireComponent(typeof(Rigidbody2D))]
public class MovForward : MonoBehaviour
{
    private Vector2 movement;

    public float speed = 5f;

    void Start()
    {
        Rigidbody2D rig = gameObject.GetComponent<Rigidbody2D>();
        rig.gravityScale = 0f;
    }

    void Update()
    {
        movement = new Vector2(1, 1);

        transform.Translate(movement * speed * Time.deltaTime);
    }

}
