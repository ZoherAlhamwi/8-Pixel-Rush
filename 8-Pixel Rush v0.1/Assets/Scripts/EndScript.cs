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
            PlayerScore player = other.GetComponent<PlayerScore>();
            if (player != null && player.score >= coinsNeeded)
            {
                SceneManager.LoadScene("level1");
            }
        }
    }
}