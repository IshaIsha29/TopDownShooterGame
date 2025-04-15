using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AmmoPickup : MonoBehaviour
{
    public int ammoAmount = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            Weapon playerWeapon = player.weapon;

            if (playerWeapon.currentAmmo < playerWeapon.maxAmmo)
            {
                playerWeapon.currentAmmo = Mathf.Min(playerWeapon.currentAmmo + ammoAmount, playerWeapon.maxAmmo);

                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Ammo is full! Can't pick up more.");
            }
        }
    }
}
