using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplosion : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            Destroy(gameObject);
        }
    }
}
