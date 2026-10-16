using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketDetector : MonoBehaviour
{
    public string basketColor;
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(basketColor))
        {
            scoreManager.score += 1;
        }
        else
        {
            scoreManager.score -= 1;
        }

        Destroy(other.gameObject);
    }
}