using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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
        if(health <= 0)
        {
            SceneManager.LoadScene("Level");
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
