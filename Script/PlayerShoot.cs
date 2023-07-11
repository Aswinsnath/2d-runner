using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    PlayerControler controler;
    public Animator animator;

    public GameObject bullet;
    public Transform bulletHole;
    public float Force = 200;
 void Awake()
    {
        controler = new PlayerControler();
        controler.Enable();
        controler.Land.Shoot.performed += ctx => Fire();
    }
    void Fire()
    {
        animator.SetTrigger("shoot");
       GameObject go =  Instantiate(bullet, bulletHole.position, bullet.transform.rotation);
        if (GetComponent<PlayerMovement>().isFacingRight)
            go.GetComponent<Rigidbody2D>().AddForce(Vector2.right * Force);
        else
        {
            go.GetComponent<Rigidbody2D>().AddForce(Vector2.left * Force);
        }
    }
}
