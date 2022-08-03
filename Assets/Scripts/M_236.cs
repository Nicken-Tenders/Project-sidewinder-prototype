using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_236 : MonoBehaviour
{
    public GameObject gamePanel;
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


    // Start is called before the first frame update
    void Start()
    {
        gamePanel.SetActive(false);
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
        StartCoroutine(Win());
    }

    IEnumerator Win()
    {
        //Disable player movement
        gamePanel.SetActive(true);
        yield return new WaitForSeconds(2);
        gamePanel.SetActive(false);
        pc.enabled = false;
    }

    public void OnEnable()
    {
        manager.promptH.text = startH;
        manager.promptB.text = startB;
        manager.sideH.text = sideH;
        manager.sideB.text = sideB;
        manager.promptH.text = endH;
        manager.promptB.text = endB;
    }
}