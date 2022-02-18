using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        //Resume previous mission
        SceneManager.LoadSceneAsync("Training room");
    }
    public void Missions()
    {

    }
    public void Settings()
    {

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App was quit");
    }
}
