using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour
{
    public int coinsCollected = 0; // counter for the number of coins collected
    public Text coinsCollectedText; // text box to display the number of coins collected

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinsCollected++; // increase the number of coins collected
            Destroy(collision.gameObject); // destroy the coin object
            UpdateCoinsText(); // update the text box with the new number of coins collected
        }
    }

    void UpdateCoinsText()
    {
        coinsCollectedText.text = "Fruits: " + coinsCollected.ToString(); // update the text box with the new number of coins collected
    }
}
