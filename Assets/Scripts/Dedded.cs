﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dedded : MonoBehaviour
{
    [SerializeField] PlayerHealth ph;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            ph.Damage(7);
        }

    }
}
