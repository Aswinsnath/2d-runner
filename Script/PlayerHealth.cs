using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class PlayerHealth : MonoBehaviour
{
    public int health = 3; // set starting health to 3
    public Image[] hearts; // array of heart sprites
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health--;
            UpdateHearts();
            if (health <= 0)
            {
                GameOver();
            }
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

    void GameOver()
    {
        // show game over screen
        Debug.Log("Game over");
    }
}
