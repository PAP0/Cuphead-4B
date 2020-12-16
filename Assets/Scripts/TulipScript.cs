using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TulipScript : MonoBehaviour
{
    Animator Tulli;

    void Start()
    {
        Tulli = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Tulli.SetBool("isIdle", false);
            Tulli.SetBool("isShooting", true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Tulli.SetBool("isIdle", true);
            Tulli.SetBool("isShooting", false);
        }
    }
}
