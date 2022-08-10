using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_236 : MonoBehaviour
{
    public GameObject mSelect;
    public GameObject clearP;
    public GameObject promptP;
    public Image[] sucNum;
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

        manager.promptH.text = startH;
        manager.promptB.text = startB;
        manager.sideH.text = sideH;
        manager.sideB.text = sideB;

        promptP.SetActive(true);
        StartCoroutine(InputWait());
    }
    IEnumerator InputWait()
    {
        yield return new WaitForSeconds(2f);
        yield return new WaitUntil(() => Input.anyKeyDown == true);
        promptP.SetActive(false);
        pc.enabled = true;
    }

    void Update()
    {
        if (CommandSequences.SequenceIsCompleted("Taunt"))
        {
            Count();
        }
    }
    void Count()
    {
        for (int i = 0; i >= 3; i++)
        {
            sucNum[i].enabled = true;
            if (i >=1)
                sucNum[i-1].enabled = false;

            if (i >= 3)
            {
                StartCoroutine(Win());
            }
        }
    }

    IEnumerator Win()
    {
        manager.promptH.text = endH;
        manager.promptB.text = endB;
        pc.enabled = false;
        clearP.SetActive(true);
        yield return new WaitForSeconds(2);
        clearP.SetActive(false);
        promptP.SetActive(true);
        yield return new WaitForSeconds(2f);
        yield return new WaitUntil(() => Input.anyKeyDown == true);
        mSelect.SetActive(true);
        promptP.SetActive(false);
        gameObject.SetActive(false);
    }
}