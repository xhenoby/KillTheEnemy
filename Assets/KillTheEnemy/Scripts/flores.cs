using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flores : MonoBehaviour
{

    Animator anim;
    public bool toc;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetBool("tocando", toc);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerIzq1"|| col.gameObject.tag == "PlayerDer1"|| col.gameObject.tag == "PlayerIzq2" || col.gameObject.tag == "PlayerDer2")
        {
            toc = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if  (col.gameObject.tag == "PlayerIzq1"|| col.gameObject.tag == "PlayerDer1"|| col.gameObject.tag == "PlayerIzq2" || col.gameObject.tag == "PlayerDer2")
        {
            toc = false;
        }
    }
}
