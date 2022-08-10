using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Check 1: " + Time.time);
        StartCoroutine(WaitForInput());
        Debug.Log("Check 5: " + Time.time);
    }

    IEnumerator WaitForInput()
    {
        Debug.Log("Check 2: " + Time.time);
        yield return new WaitForSeconds(2);
        Debug.Log("Check 3: " + Time.time);
        yield return new WaitUntil(() => Input.anyKeyDown);
        Debug.Log("Check 4: " + Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
