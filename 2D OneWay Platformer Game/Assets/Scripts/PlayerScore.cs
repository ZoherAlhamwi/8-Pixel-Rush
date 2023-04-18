using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    private void Start()
    {
        UpdateScoreDisplay();
    }
    private void LateUpdate()
    {
        UpdateScoreDisplay();

    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}
