using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] UpdateUI UIScript;
    [SerializeField] int health;
    [SerializeField] Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        Updateui();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)){
            Damage(1);
        }
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        Updateui();
        movement.GettingHit();
    }
    private void Updateui()
    {
        UIScript.ChangeUI(health);
    }
}
