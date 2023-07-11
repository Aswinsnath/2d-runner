using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithZombie : MonoBehaviour
{
    public Rigidbody2D Rb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BootCheck>())
        {
            Rb.velocity = new Vector2(Rb.velocity.x, 0f);
            Rb.AddForce(Vector2.up * 300f);
        }
    }
}
