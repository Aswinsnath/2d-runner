using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAWTOP : MonoBehaviour
{
    public float Speed = 2;
    int dir = 1;
    public Transform TopStop;
    public Transform BottomStop;

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * Speed * dir * Time.fixedDeltaTime);

      
        if ((dir == -1 && Vector3.Distance(transform.position, BottomStop.position) < 0.5f) ||
            (dir == 1 && Vector3.Distance(transform.position, TopStop.position) < 0.5f))
        {
            
            dir *= -1;
        }
    }
}
