using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public float Speed = 2;
    int dir = 1;
    public Transform LeftStop;
    public Transform RightStop;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * Speed * dir * Time.fixedDeltaTime);

        // Check if the saw has hit the left or right stop
        if ((dir == -1 && Vector3.Distance(transform.position, LeftStop.position) < 0.5f) ||
            (dir == 1 && Vector3.Distance(transform.position, RightStop.position) < 0.5f))
        {
            // If the saw has hit a stop, reverse its direction
            dir *= -1;
        }
    }
}
