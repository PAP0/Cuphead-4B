using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAnimationController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player").GetComponent<Weapon>().isShooting = true)
        {
            if (Input.GetKey(KeyCode.DownArrow))                                                                                                              
            {
                //crouch shooting
            }
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                //Angle
            }
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                //Angle
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                //Up
            }
            else
            {
                //Neutral
            }
        }
    }
}
