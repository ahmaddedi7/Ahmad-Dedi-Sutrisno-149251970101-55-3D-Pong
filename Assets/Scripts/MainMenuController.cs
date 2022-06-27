using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void HowPlay()
    {
        SceneManager.LoadScene("How to Play");
    }

    public void back()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void exit()
    {
        Application.Quit();
    }
}
