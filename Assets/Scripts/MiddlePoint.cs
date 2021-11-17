using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePoint : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject camera;
    public float side;

    // Update is called once per frame
    void Update()
    {
        camera.gameObject.transform.position = player1.gameObject.transform.position + (player1.transform.position - player2.transform.position) / 2;

        if (Mathf.Sign(player1.transform.position.x - player2.transform.position.x) == -1f)
        {
            //player1.transform.localScale = Vector3(1, 1, -1);
            //player2.transform.localScale;
        }
    }
}
