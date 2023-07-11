using UnityEngine;

public class RingCollision : MonoBehaviour
{
    public GameObject objectToDeactivate; // Ring object to deactivate
    public GameObject objectToActivate; // Game object to activate

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the triggering object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Deactivate the ring object
            objectToDeactivate.SetActive(false);

            // Activate the other game object
            objectToActivate.SetActive(true);
        }
    }
}
