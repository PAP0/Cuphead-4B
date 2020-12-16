using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushmove : MonoBehaviour
{
    [SerializeField] float movespeed;
    public float maxmovepseed;
    Rigidbody2D objectMove;

    void Start()
    {
        objectMove = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movespeed = 0;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            movespeed = maxmovepseed;
        }
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * -movespeed;
        objectMove.velocity = new Vector2(moveBy, objectMove.velocity.y);
    }
}
