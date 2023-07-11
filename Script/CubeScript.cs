using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject gameOverUI;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameOverUI.SetActive(true);
            HealthManager.health = 0;
        }
    }
}
