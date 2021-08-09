using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public GameObject restartButton;
    public Text scoreText;

    private int _score;

    void Start()
    {
        restartButton.SetActive(false);
        _score = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Pass"))
        {
            _score += 1;
            scoreText.text = _score.ToString();
        }
        else
        {
            Time.timeScale = 0;
            restartButton.SetActive(true);
        }
    }
}