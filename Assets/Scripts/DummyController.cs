using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    public Animator animator;
    public Player1Controller pc;
    public SpriteRenderer sr;
    //public Sprite

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pc.hitstun > 0)
        {
            //sr.sprite = ("")
            pc.hitstun--;
            animator.SetFloat("hitstun", pc.hitstun);
        }
        if (pc.blockstun > 0)
        {
            pc.blockstun--;
            animator.SetFloat("blockstun", pc.blockstun);
        }
        //if (pc.knockdown > 0)
        //{
        //    pc.knockdown--;
        //    animator.SetFloat("knockdown", pc.knockdown);
        //}
    }

    #region hitstates
    public void Hitstun(float hitstun)
    {
        animator.SetFloat("hitstun", hitstun);
    }
    public void Blockstun(float blockstun)
    {
        animator.SetFloat("blockstun", blockstun);
    }
    //public void Knockdown()
    //{
    //    animator.SetTrigger("knockdown");
    //}
    #endregion
}
