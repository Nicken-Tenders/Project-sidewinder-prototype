using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;

public class M_NumpadNotation : MonoBehaviour
{
    public GameObject mSelect;
    public GameObject clearP;
    public GameObject promptP;
    public GameObject paktc; //pressAnyKeyToContinue
    public GameObject[] sucNumImg;
    private int sucNum;
    public Image winNum;
    public Player1Script pc;
    public BattleManager manager;
    [Button] private void ReloadText()
    {
        manager.promptH.text = startH;
        manager.promptB.text = startB;
        manager.sideH.text = sideH;
        manager.sideB.text = sideB;
    }
    [Button]private void ReloadEndText()
    {
        manager.promptH.text = endH;
        manager.promptB.text = endB;
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

    public void OnEnable()
    {
        pc.enabled = false;
        pc.missionMove = false;

        manager.promptH.text = startH;
        manager.promptB.text = startB;
        manager.sideH.text = null;
        manager.sideB.text = null;

        promptP.SetActive(true);
        StartCoroutine(InputWait());
        sucNum = 0;
        sucNumImg[0].SetActive(true);
    }

    IEnumerator InputWait()
    {
        yield return new WaitForSeconds(2f);
        paktc.SetActive(true);
        yield return new WaitUntil(() => Input.anyKeyDown == true);
        //next page
        paktc.SetActive(false);
        promptP.SetActive(false);
        manager.sideH.text = sideH;
        manager.sideB.text = sideB;
        pc.enabled = true;
    }

    void Update()
    {
        //if ()
        //{
        //    //Count();
        //    sucNum++;
        //    sucNumImg[sucNum].SetActive(true);
        //    sucNumImg[sucNum - 1].SetActive(false);
        //
        //    if (sucNum >= 3)
        //    {
        //        StartCoroutine(Win());
        //    }
        //}
    }

    IEnumerator Win()
    {
        manager.promptH.text = endH;
        manager.promptB.text = endB;
        clearP.SetActive(true);
        yield return new WaitForSeconds(2);
        pc.enabled = false;
        pc.missionMove = true;
        clearP.SetActive(false);
        promptP.SetActive(true);
        yield return new WaitForSeconds(2f);
        paktc.SetActive(true);
        yield return new WaitUntil(() => Input.anyKeyDown == true);
        paktc.SetActive(false);
        foreach (GameObject img in sucNumImg)
            img.SetActive(false);
        sucNum = 0;
        sucNumImg[sucNum].SetActive(true);
        mSelect.SetActive(true);
        promptP.SetActive(false);
        clearP.SetActive(false);
        gameObject.SetActive(false);
    }
}