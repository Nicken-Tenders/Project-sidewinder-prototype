using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionScript : MonoBehaviour
{
    public GameObject gamePanel;
    public Player1Script pc;

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
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {
        gamePanel.SetActive(true);
        yield return new WaitForSeconds(2);
        gamePanel.SetActive(false);
    }
}
