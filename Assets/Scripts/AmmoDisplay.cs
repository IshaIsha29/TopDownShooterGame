using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro; 

public class AmmoDisplay : MonoBehaviour
{
    public Weapon weapon;
    public TMP_Text ammoText;

    private void Update()
    {
        ammoText.text = "Ammo: " + weapon.currentAmmo + "/" + weapon.maxAmmo;
    }
}
