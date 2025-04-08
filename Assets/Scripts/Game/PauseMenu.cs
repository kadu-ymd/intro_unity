using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
