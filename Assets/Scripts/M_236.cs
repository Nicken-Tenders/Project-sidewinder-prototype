using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_236 : MonoBehaviour
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
    [Space]
    public string startH;
    [TextArea] public string startB;
    [Space]
    [Space]
    public string sideH;
    [TextArea] public string sideB;
    [Space]
    [Space]
    public string endH;
    [TextArea] public string endB;



    public void OnEnable()
    {
        pc.enabled = false;
        pc.missionMove = false;

        manager.promptH.text = startH;
        manager.promptB.text = startB;
        manager.sideH.text = sideH;
        manager.sideB.text = sideB;

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
        pc.enabled = true;
    }

    void Update()
    {
        if (CommandSequences.SequenceIsCompleted("Taunt"))
        {
            //Count();
            sucNum++;
            sucNumImg[sucNum].SetActive(true);
            sucNumImg[sucNum - 1].SetActive(false);

            if (sucNum >= 3)
            {
                StartCoroutine(Win());
            }
        }
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
        yield return new WaitUntil(() => Input.anyKeyDown == true);
        foreach (GameObject img in sucNumImg)
            img.SetActive(false);
        sucNumImg[0].SetActive(true);
        sucNum = 0;
        mSelect.SetActive(true);
        promptP.SetActive(false);
        clearP.SetActive(false);
        gameObject.SetActive(false);
    }
}