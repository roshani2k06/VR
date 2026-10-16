using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score : " + score;
    }
}