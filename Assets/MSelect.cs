using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MSelect : MonoBehaviour
{
    void Start()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main menu");
    }
}
