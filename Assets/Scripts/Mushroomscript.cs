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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            MushroomAnim.SetBool("isGettingUp", true);
            MushroomAnim.SetBool("isGoingDown", false);

        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            MushroomAnim.SetBool("isGettingUp", false);
            MushroomAnim.SetBool("isGoingDown", true);
        }
    }
}
