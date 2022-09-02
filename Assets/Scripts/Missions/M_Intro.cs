using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;

public class M_Intro : MonoBehaviour
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

    public GameObject targetParent;
    public List<GameObject> targetArray;
    private List<GameObject> targets;

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

    public void OnAwake()
    {
        
    }

    public void OnEnable()
    {
        #region Universal mission enable
        pc.enabled = false;
        pc.missionMove = false;

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

        promptP.SetActive(true);
        #endregion

        targets = new List<GameObject>();

        foreach (Transform child in targetParent.transform)
        {
            targets.Add(child.gameObject);
        }

        //targetArray = new GameObject[targetParent.transform.childCount];
        //targetArray = targetParent.transform.GetChild;
        //foreach (GameObject child in targetParent.transform)
        //{
        //    targetArray
        //}
        //targetArray = new List<GameObject>();//Transform[targetParent.transform.GetComponents<Transform>().Length];
        //targetArray = targetParent.GetComponents<Transform>();

        //foreach (Transform target in targetArray)
        //{
        //    Debug.Log(target.name);
        //    target.gameObject.SetActive(true);
        //    targets.Add(target.gameObject);
        //}

        winNum = targetArray.Count;
        winNumImg[winNum].SetActive(true);

        StartCoroutine(InputWait());
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

        pc.missionMove = true;
    }

    void Update()
    {
        for (int i = targets.Count - 1; i >= 0; i--)
        {
            if (targets[i].activeInHierarchy == false)
            {
                targets.RemoveAt(i);

                sucNumImg[sucNum].SetActive(false);
                sucNum++;
                sucNumImg[sucNum].SetActive(true);

                if (sucNum >= winNum)
                {
                        StartCoroutine(Win());
                }
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
        yield return new WaitUntil(() => Input.anyKeyDown == true);

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