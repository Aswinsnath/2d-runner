using UnityEngine;

public class Chest : MonoBehaviour
{
    public Animator animator;
    public GameObject levelCompleteScreen;
    public ParticleSystem particleSystem;
    public GameObject Heart;
    public GameObject ring;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && ring.activeSelf)
        {
            animator.SetTrigger("Open");
            other.GetComponent<PlayerMovement>().enabled = false;
            other.GetComponent<Animator>().enabled = false;
            levelCompleteScreen.SetActive(true);
            particleSystem.Play();
            Heart.SetActive(false);
        }
    }
}
