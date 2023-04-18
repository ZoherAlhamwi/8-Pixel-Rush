using System.Collections;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float speedBoost = 5f; // Set the amount of speed boost to apply
    public int powerupDuration = 10; // Set the duration of the power-up in seconds

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Destroy the coin
            Destroy(gameObject);

            // Activate the power-up
            ActivatePowerup();
        }
    }

    private void ActivatePowerup()
    {
        // Get the player's movement script
        PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();

        // Apply the speed boost
        playerMovement.speed += speedBoost;

        // Wait for the duration of the power-up
        StartCoroutine(DeactivatePowerupAfterDelay(playerMovement));
    }

    private IEnumerator DeactivatePowerupAfterDelay(PlayerMovement playerMovement)
    {
        yield return new WaitForSeconds(powerupDuration);

        // Deactivate the power-up effects
        playerMovement.speed -= speedBoost;
    }
}