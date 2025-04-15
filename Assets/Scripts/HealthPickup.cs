using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthPickup : MonoBehaviour
{
    public int healthAmount = 20;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healthAmount);
                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("Health component not found on the player.");
            }
        }
    }
}
