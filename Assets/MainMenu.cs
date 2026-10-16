using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene("GameScene"); // your scene name
    }

    public void ExitGame()
    {
        Debug.Log("Exit Button Pressed");
        Application.Quit();
    }
}