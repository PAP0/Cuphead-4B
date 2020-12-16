using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticles : MonoBehaviour
{
    [SerializeField] GameObject SprintPart;
    [SerializeField] GameObject LandPart;
    public float Timer;
    public float partTime;
    bool isGrounded = false;
    [SerializeField] Transform isGroundedChecker;
    [SerializeField] float checkGroundRadius;
    [SerializeField] LayerMask groundLayer;


    void Update()
    {
        Timer -= Time.deltaTime;
        SprintParticle();
        if(Timer < 0)
        {
            Timer = partTime;
        }
        CheckIfGrounded();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
       if(col.gameObject.tag.Equals ("Ground"))
        {
            Instantiate(LandPart, transform.position, LandPart.transform.rotation);
        }
    }

    void SprintParticle()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isGrounded == true) 
        {
            if (Timer < 0.0001 && isGrounded == true)
            {
                Instantiate(SprintPart, transform.position, SprintPart.transform.rotation);
            }
        }
    }
    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        isGrounded = collider != null ? true : false;
    }
}
