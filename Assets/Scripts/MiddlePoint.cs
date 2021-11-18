using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePoint : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject camera;
    public float side;

    public Transform focusPoint;

    // Update is called once per frame
    void Update()
    {
        float x = (player1.gameObject.transform.position.x + player2.transform.position.x) / 2;
        float y = (player1.gameObject.transform.position.y + player2.transform.position.y) / 2;

        focusPoint.position = new Vector3(x, y, focusPoint.position.z);

        if (player1.gameObject.transform.position.x > player2.transform.position.x)
        {
            player1.transform.localScale = new Vector3(-1, 1, 1);
            player2.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            player1.transform.localScale = new Vector3(1, 1, 1);
            player2.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
