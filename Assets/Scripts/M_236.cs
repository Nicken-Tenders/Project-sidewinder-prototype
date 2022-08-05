using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_236 : MonoBehaviour
{
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

        MissionStart();
        //promptP.SetActive(true);
        //Debug.Log("before wait");
        //Wait();
        //InputWait();
        //promptP.SetActive(false);
        //Debug.Log("Button pressed");
        //pc.enabled = true;
        //while (Input.anyKey)
        //{
        //    promptP.SetActive(false);
        //    Debug.Log("Button pressed");
        //    pc.enabled = true;
        //}

    }

    IEnumerator MissionStart()
    {
        promptP.SetActive(true);
        Debug.Log("before wait");
        //Wait();
        new WaitForSeconds(5);
        //InputWait();
        new WaitUntil(() => Input.anyKeyDown);
        promptP.SetActive(false);
        Debug.Log("Button pressed");
        pc.enabled = true;
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {

        if (CommandSequences.SequenceIsCompleted("Taunt"))
        {
            Count();
        }
    }
    void Count()
    {
        for (int i = 0; i <= 3; i++)
        {
            sucNum[i].enabled = false;
            sucNum[i + 1].enabled = true;
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
    }

    
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("after wait");
    }

    IEnumerator InputWait()
    {
        yield return new WaitUntil(() => Input.anyKeyDown);

        //bool done = false;
        //if (Input.anyKeyDown)
        //    done = true;
        //if (Input.anyKeyDown)
        //{
        //    yield return;
        //}
        //else
        //{
        //    WaitUntil
        //}
    }
}