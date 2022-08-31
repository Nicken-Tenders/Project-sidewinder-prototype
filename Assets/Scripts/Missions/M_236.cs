using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;

public class M_236 : MonoBehaviour
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
    #endregion

    public void OnEnable()
    {
        #region Universal mission enable
        pc.enabled = false;
        pc.missionMove = false;

        bm.promptH.text = startH;
        bm.promptB.text = startB;
        bm.sideH.text = null;
        bm.sideB.text = null;

        promptP.SetActive(true);
        StartCoroutine(InputWait());
        foreach (GameObject img in sucNumImg)
            img.SetActive(false);
        sucNum = 0;
        sucNumImg[0].SetActive(true);
        foreach (GameObject img in winNumImg)
            img.SetActive(false);
        winNumImg[winNum].SetActive(true);
        #endregion
    }

    IEnumerator InputWait()
    {
        #region Universal mission start
        yield return new WaitForSeconds(2f);
        contP.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J) == true);
        //next page
        contP.SetActive(false);
        promptP.SetActive(false);
        bm.sideH.text = sideH;
        bm.sideB.text = sideB;
        pc.enabled = true;
        #endregion
    }

    void Update()
    {
        if (CommandSequences.SequenceIsCompleted("Taunt"))
        {
            sucNumImg[sucNum].SetActive(false);
            sucNum++;
            sucNumImg[sucNum].SetActive(true);

            if (sucNum >= winNum)
            {
                StartCoroutine(Win());
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
        pc.missionMove = true;
        clearP.SetActive(false);
        promptP.SetActive(true);
        yield return new WaitForSeconds(2f);

        contP.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J) == true);

        contP.SetActive(false);
        sucNum = 0;
        sucNumImg[sucNum].SetActive(true);
        mSelect.SetActive(true);
        promptP.SetActive(false);
        clearP.SetActive(false);
        gameObject.SetActive(false);
        #endregion
    }
}