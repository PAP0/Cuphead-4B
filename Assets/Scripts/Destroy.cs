using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float destroyAfter;
    void Start()
    {
        Destroy(gameObject, destroyAfter);
    }
}
