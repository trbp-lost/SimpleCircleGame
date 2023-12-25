using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Bounce : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        Rigidbody2D rig = GetComponent<Rigidbody2D>();
        rig.gravityScale = 1f;
        rig.velocity = transform.right * speed;
    }

}
