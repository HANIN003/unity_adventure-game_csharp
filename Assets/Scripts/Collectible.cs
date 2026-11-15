using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Add logic for what happens when the player collects the item
            Debug.Log("Collectible collected!");
            ScoreManager.Instance.AddPoint();
            Destroy(gameObject);
        }
    }

}
