using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SpeedPowerUp : MonoBehaviour
{
    // The amount to increase the game object's speed by
    public float speedIncrease = 5.0f;

    // The duration of the speed increase in seconds
    public float duration = 10.0f;

    // Text object to display the duration of the speed power-up
    public Text durationText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other game object has a "PlayerController" component
        PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();

        if (player != null)
        {
            // Increase the game object's speed by the specified amount
            player.speed += speedIncrease;

            // Start the timer to disable the speed increase
            StartCoroutine(DisableSpeedIncrease(player));
        }
    }

    private IEnumerator DisableSpeedIncrease(PlayerMovement player)
    {
        float timer = duration;

        while (timer > 0)
        {
            // Update the duration text with the remaining time
            durationText.text = "Speed: " + timer.ToString("F1") + "s";

            // Wait for the next frame
            yield return null;

            // Decrement the timer
            timer -= Time.deltaTime;
        }

        // Decrease the game object's speed by the specified amount
        player.speed -= speedIncrease;

        // Disable the speed power-up game object
        Destroy(gameObject);

    }

    private void Start()
    {
    }
}
