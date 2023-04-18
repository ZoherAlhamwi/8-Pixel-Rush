using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    private bool playerIsDead = false;

    // Call this method when the player dies
    public void PlayerDied()
    {
        if (!playerIsDead)
        {
            playerIsDead = true;
            Invoke("ReloadScene", 3f); // Wait 3 seconds before reloading the scene
        }
    }

    // Reload the scene
    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
