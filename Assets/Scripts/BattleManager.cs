using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class BattleManager : MonoBehaviour
{
    public InputActionAsset controls;
    private Vector2 moveVar;
    [HideInInspector] public int dirNum = 5;
    [HideInInspector] public int misNum;
    public Image[] dirNumImg;
    public Image atkImg;
    public TextMeshProUGUI promptH;
    public TextMeshProUGUI promptB;
    public TextMeshProUGUI sideH;
    public TextMeshProUGUI sideB;
    public GameObject missionP;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        missionP.SetActive(true);
    }

    void Update()
    {
        if (moveVar == new Vector2(-1, -1))
        {
            dirNum = 1;
        }
        if (moveVar == new Vector2(0, -1))
        {
            dirNum = 2;
        }
        if (moveVar == new Vector2(1, -1))
        {
            dirNum = 3;
        }
        if (moveVar == new Vector2(-1, 0))
        {
            dirNum = 4;
        }
        if (moveVar == new Vector2(0, 0))
        {
            dirNum = 5;
        }
        if (moveVar == new Vector2(1, 0))
        {
            dirNum = 6;
        }
        if (moveVar == new Vector2(-1, 1))
        {
            dirNum = 7;
        }
        if (moveVar == new Vector2(0, 1))
        {
            dirNum = 8;
        }
        if (moveVar == new Vector2(1, 1))
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

    public void CurrentDirection(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            moveVar = context.ReadValue<Vector2>();
        }
    }

    public void Attack(InputAction.CallbackContext context)
    {
        if (context.performed)
            atkImg.color = Color.red;
        else
            atkImg.color = Color.white;
    }
}
