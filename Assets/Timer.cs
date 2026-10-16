using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft = 5f;

    public TextMeshProUGUI timerText;
    public GameObject gameOverText;

    bool gameEnded = false;

    void Update()
    {
        if (gameEnded)
            return;

        timeLeft -= Time.deltaTime;

        timerText.text = "Time : " + Mathf.Ceil(timeLeft);

        if (timeLeft <= 0)
        {
            gameEnded = true;

            gameOverText.SetActive(true);

            Debug.Log("GAME OVER");

            Time.timeScale = 0;
        }
    }
}