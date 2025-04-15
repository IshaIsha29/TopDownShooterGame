using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public Health playerHealth;
    public TMP_Text healthText;

    private void Update()
    {
        healthText.text = "Health: " + playerHealth.currentHealth + "/" + playerHealth.maxHealth;
    }
}
