using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenOptions()
    {
        Debug.Log("Opciones");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}