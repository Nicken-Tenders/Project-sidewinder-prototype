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

    public void Resume()
    {
        //Resume previous mission
        SceneManager.LoadSceneAsync("Training room");
    }
    public void Missions()
    {
        SceneManager.LoadSceneAsync("Mission select");
    }
    public void mainMenu()
    {
        SceneManager.LoadSceneAsync("Main menu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App was quit");
    }
}
