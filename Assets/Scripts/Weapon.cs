using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate;
    private float lastFired;
    

    void Update()
    {
        if (Input.GetKey("x"))
        {
            if (Time.time - lastFired > 1 / fireRate)
            {
                lastFired = Time.time;
                Shoot();
            }
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            firePoint.transform.localPosition = new Vector3(2.38f, -1.37f, 0f);
        }
        else if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            AimAngled();
        }
        else if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            AimAngled();
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            AimUp();
        }        
        else
        {
            ResetRotation();
            ResetPosition();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);     
    }

    void ResetPosition()
    {
        firePoint.transform.localPosition = new Vector3(2.38f, -0.63f, 0f);
    }

    void ResetRotation()
    {        
        if(GameObject.Find("Player").GetComponent<Movement>().facingRight == true)
        {
            firePoint.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (GameObject.Find("Player").GetComponent<Movement>().facingRight == false)
        {
            firePoint.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
        }
    }

    void AimUp()
    {
        firePoint.transform.localPosition = new Vector3(0f, 2.70f, 0f);
        firePoint.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
    }

    void AimAngled()
    {
        firePoint.transform.localPosition = new Vector3(2.38f, 2.15f, 0f);
        if (GameObject.Find("Player").GetComponent<Movement>().facingRight == true)
        {
            firePoint.transform.rotation = Quaternion.Euler(0f, 0f, 45f);
        }
        else if (GameObject.Find("Player").GetComponent<Movement>().facingRight == false)
        {
            firePoint.transform.rotation = Quaternion.Euler(0f, 0f, 135f);
        }
        
    }
}
