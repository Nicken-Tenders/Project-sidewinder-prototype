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
    public Image[] dirImg;
    public Image atkImg;
    public TextMeshProUGUI promptH;
    public TextMeshProUGUI promptB;
    public TextMeshProUGUI sideH;
    public TextMeshProUGUI sideB;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveVar == new Vector2(-1, -1))
        {
            dirImg[0].color = Color.red;
        }
        else
        {
            dirImg[0].color = Color.white;
        }

        if (moveVar == new Vector2(0, -1))
        {
            dirImg[1].color = Color.red;
        }
        else
        {
            dirImg[1].color = Color.white;
        }

        if (moveVar == new Vector2(1, -1))
        {
            dirImg[2].color = Color.red;
        }
        else
        {
            dirImg[2].color = Color.white;
        }

        if (moveVar == new Vector2(-1, 0))
        {
            dirImg[3].color = Color.red;
        }
        else
        {
            dirImg[3].color = Color.white;
        }

        if (moveVar == new Vector2(0, 0))
        {
            dirImg[4].color = Color.red;
        }
        else
        {
            dirImg[4].color = Color.white;
        }

        if (moveVar == new Vector2(1, 0))
        {
            dirImg[5].color = Color.red;
        }
        else
        {
            dirImg[5].color = Color.white;
        }

        if (moveVar == new Vector2(-1, 1))
        {
            dirImg[6].color = Color.red;
        }
        else
        {
            dirImg[6].color = Color.white;
        }

        if (moveVar == new Vector2(0, 1))
        {
            dirImg[7].color = Color.red;
        }
        else
        {
            dirImg[7].color = Color.white;
        }

        if (moveVar == new Vector2(1, 1))
        {
            dirImg[8].color = Color.red;
        }
        else
        {
            dirImg[8].color = Color.white;
        }
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
