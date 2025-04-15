using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Key : MonoBehaviour
{
    public DoorManager doorManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            doorManager.CollectedKey(gameObject);

            doorManager.TriggerDoorAnimationForKey(gameObject);

            Destroy(gameObject);
        }
    }
}
