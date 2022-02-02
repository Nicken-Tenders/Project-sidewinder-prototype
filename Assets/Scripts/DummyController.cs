using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    public Animator animator;
    public Player1Controller pc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    #region hitstates
    public void Hitstun(int lpHitstun)
    {
        animator.SetFloat("hitstun", pc.hitstun);
    }
    public void Knockdown()
    {
        animator.SetTrigger("knockdown");
    }
    public void Blockstun()
    {
        animator.SetTrigger("blockstun");
    }
    #endregion
}
