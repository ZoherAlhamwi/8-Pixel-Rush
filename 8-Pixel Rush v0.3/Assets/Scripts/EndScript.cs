using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndScript : MonoBehaviour
{
    public int coinsNeeded = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinPickup player = other.GetComponent<CoinPickup>();
            if (player != null && player.coinsCollected >= coinsNeeded)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}