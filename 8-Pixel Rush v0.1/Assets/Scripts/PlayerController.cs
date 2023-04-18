using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private DeathManager deathmanager;

    private void Start()
    {
        deathmanager = FindObjectOfType<DeathManager>();
    }

    // Call this method when the player dies
    private void Die()
    {
        deathmanager.PlayerDied();
    }
}
