using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("Coin PickedUp");
            Destroy(this.gameObject);
        }
        
    }
    

}
