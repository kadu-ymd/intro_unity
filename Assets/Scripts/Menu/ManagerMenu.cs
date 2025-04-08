using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}