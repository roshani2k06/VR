using UnityEngine;
using TMPro;

public class CollectableZone : MonoBehaviour
{
    public TMP_Text scoreText;   // UI Text
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            score++;
            scoreText.text = "Count: " + score;

            // Optional: stop object from moving
            other.gameObject.SetActive(false);
        }
    }
}
