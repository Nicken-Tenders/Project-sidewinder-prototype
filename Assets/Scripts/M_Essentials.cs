using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_Essentials : MonoBehaviour
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

    }
    IEnumerator Win()
    {
        gamePanel.SetActive(true);
        yield return new WaitForSeconds(2);
        gamePanel.SetActive(false);
    }
}
