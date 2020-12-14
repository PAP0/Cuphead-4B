using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCollision : MonoBehaviour
{
    [SerializeField]PlayerHealth ph;
    // Start is called before the first frame update
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("Test");
            ph.Damage(2);
        }
        
    }
    

}
