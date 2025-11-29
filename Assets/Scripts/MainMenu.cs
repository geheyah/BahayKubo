using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button start, close;

    public void Start()
    {
        start.onClick.AddListener(StartGame);
        close.onClick.AddListener(ExitGame);
    }

    public void StartGame()
    {
       SceneManager.LoadScene("Gameplay"); 
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
