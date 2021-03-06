using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_236 : MonoBehaviour
{
    public GameObject gamePanel;
    public Player1Script pc;
    public Text titleT;
    public Text bodyT;

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
    }
}