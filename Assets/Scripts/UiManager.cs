using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

    void Start()
    {

    }

    public void Play()
    {
        //Resume previous mission
        SceneManager.LoadSceneAsync("Training room");
    }
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main menu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App was quit");
    }
}
