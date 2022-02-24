using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject prefPanel;
    public GameObject quitWarnPanel;
    // Start is called before the first frame update
    void Start()
    {
        prefPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        GetComponentInParent<GameObject>().SetActive(false);
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
    public void Settings()
    {
        prefPanel.SetActive(true);
    }
    public void mainMenu()
    {
        SceneManager.LoadSceneAsync("Main menu");
    }
    public void QuitWarn()
    {
        quitWarnPanel.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App was quit");
    }
}
