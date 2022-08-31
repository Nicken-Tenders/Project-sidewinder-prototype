using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MManager : MonoBehaviour
{
    public void Quit()
    {
        //Reset
        //Disable
    }

    public void MissionSelect()
    {
        SceneManager.LoadScene("Training room");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
}
