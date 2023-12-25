using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector2 currentPosition = transform.position;
        Vector2 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Vector2.Lerp(currentPosition, targetPosition, speed * Time.deltaTime);
    }
}
