using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public void LoadMainLevel()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadMainScreen()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CloseGame()
    {
        Debug.Log("Game closed!");
        Application.Quit();
    }
}
