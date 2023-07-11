using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerManager.lastCheckPointPos = transform.position;
            AudioManager.instance.Play("Checkpoint");
            GetComponent<SpriteRenderer>().color = Color.white;
            PlayerManager.currentLevel = SceneManager.GetActiveScene().buildIndex;
        }
    }

}
