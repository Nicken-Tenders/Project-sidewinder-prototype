using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class BattleManager : MonoBehaviour
{
    public Player1Script ps;
    [HideInInspector] public int dirNum = 5;
    [HideInInspector] public int misNum;
    public Image[] dirNumImg;
    public Image pImg;
    public Image kImg;
    public TextMeshProUGUI promptH;
    public TextMeshProUGUI promptB;
    public TextMeshProUGUI sideH;
    public TextMeshProUGUI sideB;
    public GameObject missionP;
    public GameObject pauseP;
    public float lastTimeScale;
    //public GameObject currentMission;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        missionP.SetActive(true);
        pauseP.SetActive(false);
    }

    void Update()
    {
        if (ps.moveVar == new Vector2(-1, -1))
        {
            dirNum = 1;
        }
        if (ps.moveVar == new Vector2(0, -1))
        {
            dirNum = 2;
        }
        if (ps.moveVar == new Vector2(1, -1))
        {
            dirNum = 3;
        }
        if (ps.moveVar == new Vector2(-1, 0))
        {
            dirNum = 4;
        }
        if (ps.moveVar == new Vector2(0, 0))
        {
            dirNum = 5;
        }
        if (ps.moveVar == new Vector2(1, 0))
        {
            dirNum = 6;
        }
        if (ps.moveVar == new Vector2(-1, 1))
        {
            dirNum = 7;
        }
        if (ps.moveVar == new Vector2(0, 1))
        {
            dirNum = 8;
        }
        if (ps.moveVar == new Vector2(1, 1))
        {
            dirNum = 9;
        }

        foreach (Image img in dirNumImg)
        {
            img.color = Color.white;
            if (img == dirNumImg[misNum])
                img.color = new Vector4(1, 1, 0.5f, 1);
            if (img == dirNumImg[dirNum])
                img.color = Color.red;
        }

        //foreach (Image img in dirNumImg)
        //{
        //    img.color = Color.white;
        //    if (img == dirNumImg[misNum])
        //        img.color = Color.red;
        //    Debug.Log(misNum);
        //}

       
    }

    public void AtkP(InputAction.CallbackContext context)
    {
        if (context.performed)
            pImg.color = Color.red;
        else
            pImg.color = Color.white;
    }
    public void AtkK(InputAction.CallbackContext context)
    {
        if (context.performed)
            kImg.color = Color.red;
        else
            kImg.color = Color.white;
    }

    public void Pause(InputAction.CallbackContext context)
    {
        if (context.performed)
        {;
            if (pauseP.activeInHierarchy == false)
            {
                lastTimeScale = Time.timeScale;
                SetTimeScale(0);
                pauseP.SetActive(true);
            }
            else if (pauseP.activeInHierarchy == true)
            {
                SetTimeScale(lastTimeScale);
                pauseP.SetActive(false);
            }
        }
    }

    public void SetTimeScale(float scale)
    {
        Time.timeScale = scale;
    }
}
