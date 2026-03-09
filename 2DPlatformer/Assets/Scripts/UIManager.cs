using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    void OnEnable()
    {
        GameManager.Instance.onScoreChanged += UpdateScore;
        GameManager.Instance.onHealthChanged += UpdateHealth;
        GameManager.Instance.onGameOver += HandleGameOver;
    }

    void OnDisable()
    {
        GameManager.Instance.onScoreChanged -= UpdateScore;
        GameManager.Instance.onHealthChanged -= UpdateHealth;
        GameManager.Instance.onGameOver -= HandleGameOver;
    }

    void UpdateScore(int score)
    {
        Debug.Log("Score updated: " + score);
        scoreText.text = "Score: " + score;
    }

    void UpdateHealth(int health)
    {
        Debug.Log("Health updated: " + health);
        healthText.text = "Health: " + health;
    }

    void HandleGameOver()
    {
        Debug.Log("Game Over triggered");
        SceneManager.LoadScene("GameOver");
    }
}