using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MManager : MonoBehaviour
{
    void Start()
    {
        
    }

    public void MissionSelect()
    {
        SceneManager.LoadSceneAsync("Training room");
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main menu");
    }
}
