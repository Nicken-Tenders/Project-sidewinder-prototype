using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePoint : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public Transform focusPoint;

    void Update()
    {
        if (player2.activeInHierarchy == true)
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
        else
        {
            focusPoint.position = new Vector3(player1.gameObject.transform.position.x + 3.5f, (player1.gameObject.transform.position.y / 2) + 2, focusPoint.position.z);
        }
    }
}
