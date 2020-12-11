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
        if (Input.GetButton("Fire1"))
        {
            if (Time.time - lastFired > 1 / fireRate)
            {
                lastFired = Time.time;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);     
    }
}
