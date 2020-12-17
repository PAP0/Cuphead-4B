using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroomscript : MonoBehaviour
{
    Animator MushroomAnim;

    void Start()
    {
        MushroomAnim = GetComponent<Animator>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        MushroomAnim.SetBool("isShooting", true);
        MushroomAnim.SetBool("isGettingUp", false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            MushroomAnim.Play("GetUp");
            MushroomAnim.SetBool("isGettingUp", true);
            MushroomAnim.SetBool("isShooting", false);
            MushroomAnim.SetBool("isGoingDown", false);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            MushroomAnim.SetBool("isGettingUp", false);
            MushroomAnim.SetBool("isGoingDown", true);
            MushroomAnim.SetBool("isShooting", false);
        }
    }
}
