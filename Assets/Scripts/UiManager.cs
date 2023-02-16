using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public void LoadScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App was quit");
    }
}
