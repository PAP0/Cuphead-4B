using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int health;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Bullet"){
           if(health <= 1){
            Destroy(this.gameObject);
            }else{
           takeDamage(); 
            } 
        }
        
        
    }

    void takeDamage(){
        health -= 1;
    }
}
