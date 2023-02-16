using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;

public class M_Essentials : MonoBehaviour
{
    #region Universal mission declarations
    public GameObject mSelect;
    public GameObject clearP;
    public GameObject promptP;
    public GameObject contP;
    private int sucNum;
    public GameObject[] sucNumImg;
    [SerializeField] private int winNum;
    public GameObject[] winNumImg;
    public Player1Script pc;
    public BattleManager bm;
    #endregion

    #region Universal mission text
    public string sideH;
    [ResizableTextArea] public string sideB;
    [Space]
    [Space]
    public string startH;
    [ResizableTextArea] public string startB;
    [Space]
    [Space]
    public string endH;
    [ResizableTextArea] public string endB;

    [Button] private void LoadStartText()
    {
        promptP.SetActive(true);
        bm.promptH.text = startH;
        bm.promptB.text = startB;
    }
    [Button] private void LoadSideText()
    {
        promptP.SetActive(false);
        bm.sideH.text = sideH;
        bm.sideB.text = sideB;
    }
    [Button] private void LoadEndText()
    {
        promptP.SetActive(true);
        bm.promptH.text = endH;
        bm.promptB.text = endB;
    }
    #endregion

    [Space]
    [Space]
    public string quickH;
    [ResizableTextArea] public string quickB;
    [Space]
    [Space]
    public string farH;
    [ResizableTextArea] public string farB;
    [Space]
    [Space]
    public string aaH;
    [ResizableTextArea] public string aaB;
    [Button] private void LoadQuickText()
    {
        promptP.SetActive(true);
        bm.promptH.text = quickH;
        bm.promptB.text = quickB;
    }
    [Button] private void LoadLongText()
    {
        promptP.SetActive(true);
        bm.promptH.text = farH;
        bm.promptB.text = farB;
    }
    [Button] private void LoadAAText()
    {
        promptP.SetActive(true);
        bm.promptH.text = aaH;
        bm.promptB.text = aaB;
    }

    public GameObject[] targets;
    public bool active0;
    public bool active1;
    public bool active2;
    public bool won = false;

    public void OnEnable()
    {
        #region Universal mission enable
        pc.enabled = false;
        pc.missionMove = false;
        pc.transform.parent.position = new Vector2(-3.5f, 0f);

        bm.promptH.text = startH;
        bm.promptB.text = startB;
        bm.sideH.text = null;
        bm.sideB.text = null;

        foreach (GameObject img in sucNumImg)
            img.SetActive(false);
        sucNum = 0;
        sucNumImg[0].SetActive(true);
        foreach (GameObject img in winNumImg)
            img.SetActive(false);
        winNumImg[winNum].SetActive(true);

        promptP.SetActive(true);
        #endregion

        foreach (GameObject target in targets)
        {
            target.SetActive(true);
        }

        active0 = true;
        active1 = true;
        active2 = true;

        winNum = targets.Length;
        winNumImg[winNum].SetActive(true);

        StartCoroutine(InputWait());
    }

    IEnumerator InputWait()
    {
        #region Universal mission start
        bm.SetTimeScale(0);
        yield return new WaitForSecondsRealtime(2f);
        contP.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) == true);
        //next page
        contP.SetActive(false);
        promptP.SetActive(false);
        bm.sideH.text = sideH;
        bm.sideB.text = sideB;
        pc.enabled = true;
        bm.SetTimeScale(1);
        #endregion

        pc.missionMove = false;


    }

    void Update()
    {
        if (sucNum >= winNum)
        {
            if (won == false)
            {
                if (Time.timeScale == 1)
                {
                    won = true;
                    StartCoroutine(Win());
                }
            }
        }

        if (targets[0].activeInHierarchy == false)
        {
            if (active0 == true)
            {
                active0 = false;
                pc.enabled = false;
                bm.promptH.text = quickH;
                bm.promptB.text = quickB;
                promptP.SetActive(true);
                StartCoroutine(InputWait());
                pc.enabled = true;
                sucNumImg[sucNum].SetActive(false);
                sucNum++;
                sucNumImg[sucNum].SetActive(true);
            }
        }

        if (targets[1].activeInHierarchy == false)
        {
            if (active1 == true)
            {
                active1 = false;
                pc.enabled = false;
                bm.promptH.text = farH;
                bm.promptB.text = farB;
                promptP.SetActive(true);
                StartCoroutine(InputWait());
                pc.enabled = true;
                sucNumImg[sucNum].SetActive(false);
                sucNum++;
                sucNumImg[sucNum].SetActive(true);
            }
        }
        
        if (targets[2].activeInHierarchy == false)
        {
            if (active2 == true)
            {
                active2 = false;
                pc.enabled = false;
                bm.promptH.text = aaH;
                bm.promptB.text = aaB;
                promptP.SetActive(true);
                StartCoroutine(InputWait());
                pc.enabled = true;
                sucNumImg[sucNum].SetActive(false);
                sucNum++;
                sucNumImg[sucNum].SetActive(true);
            }
        }
    }

    IEnumerator Win()
    {
        #region Universal mission win
        bm.promptH.text = endH;
        bm.promptB.text = endB;
        clearP.SetActive(true);
        yield return new WaitForSeconds(2);

        pc.enabled = false;
        clearP.SetActive(false);
        promptP.SetActive(true);
        yield return new WaitForSeconds(2f);

        contP.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) == true);

        contP.SetActive(false);
        sucNum = 0;
        sucNumImg[sucNum].SetActive(true);
        mSelect.SetActive(true);
        promptP.SetActive(false);
        clearP.SetActive(false);
        #endregion

        active0 = false;
        active1 = false;
        active2 = false;

        foreach (GameObject target in targets)
            target.SetActive(false);

        gameObject.SetActive(false);
    }
}