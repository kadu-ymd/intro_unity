using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Level1");
        Timer.elapsedTime = 0;
        Time.timeScale = 1;
    }

    public void SelectLevel()
    {
        SceneManager.LoadSceneAsync("LevelSelection");
    }

    public void PlayLevel(int level_number)
    {
        SceneManager.LoadSceneAsync("Level" + level_number);
        Timer.elapsedTime = 0;
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
        Timer.elapsedTime = 0;
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}