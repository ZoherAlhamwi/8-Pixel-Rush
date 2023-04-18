using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Increase the player's score by the coin value.
            PlayerScore playerScore = other.GetComponent<PlayerScore>();
            if (playerScore != null)
            {
                playerScore.IncreaseScore(coinValue);
                playerScore.scoreText.text = "Score: " + playerScore.score;
            }

            // Destroy the coin object.
            Destroy(gameObject);
        }
    }
}
