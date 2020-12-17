using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAnimationController : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if(GameObject.Find("Player").GetComponent<Weapon>().isShooting == true)
        {
            animator.SetBool("IsShooting", true);
        }
        else if(GameObject.Find("Player").GetComponent<Weapon>().isShooting == false)
        {
            animator.SetBool("IsShooting", false);
        }
    }
}
