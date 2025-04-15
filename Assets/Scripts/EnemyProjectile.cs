using UnityEngine;
using System.Collections.Generic;

public class EnemyProjectile : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health playerHealth = collision.GetComponent<Health>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
            Destroy(gameObject);
        }
    }
}
