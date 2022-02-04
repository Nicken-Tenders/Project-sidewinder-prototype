using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    public Animator animator;
    public Player1Controller pc;
    public SpriteRenderer sr;
    private Color ogColor;
    private Color hitColor;

    // Start is called before the first frame update
    void Start()
    {
        ogColor = sr.color;
        hitColor = ogColor;
        hitColor.r = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.hitstun > 0)
        {
            pc.hitstun--;
            animator.SetFloat("hitstun", pc.hitstun);
        }
    }

    #region hitstates
    public void Hitstun(float hitstun)
    {
        //StartCoroutine(Hitflash());
        animator.SetFloat("hitstun", hitstun);
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
    
    IEnumerator Hitflash()
    {
        sr.color = hitColor;
        yield return new WaitForSeconds(0.5f);
        sr.color = ogColor;
    }
}
