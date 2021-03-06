﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [SerializeField] BoxCollider2D Idlecoll;
    [SerializeField] BoxCollider2D Crouchcoll;
    [SerializeField] BoxCollider2D Walkcoll;
    bool isCrouching;



    void Start()
    {
        Idlecoll.enabled = true;
        Crouchcoll.enabled = false;
        Walkcoll.enabled = false;
    }

    void Update()
    {
        Crouching();
        Walking();
    }

    void Crouching()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            isCrouching = true;
            Idlecoll.enabled = false;
            Crouchcoll.enabled = true;
            Walkcoll.enabled = false;
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            isCrouching = false;
            Idlecoll.enabled = true;
            Crouchcoll.enabled = false;
            Walkcoll.enabled = false;
        }
    }

    void Walking()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) && isCrouching == false)
        {
            Idlecoll.enabled = false;
            Crouchcoll.enabled = false;
            Walkcoll.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Idlecoll.enabled = true;
            Crouchcoll.enabled = false;
            Walkcoll.enabled = false;
        }
    }

}
