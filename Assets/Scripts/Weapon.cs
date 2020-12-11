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


        

        if (Input.GetKey(KeyCode.DownArrow))
        {
            firePoint.transform.localPosition = new Vector3 (2.38f, -1.37f, 0f);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            firePoint.transform.localPosition = new Vector3(2.38f, -0.63f, 0f);
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);     
    }
}
