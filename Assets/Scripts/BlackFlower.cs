using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFlower : MonoBehaviour
{
    public GameObject lowHitbox;
    public GameObject hiHitbox;

    void Start()
    {
       // hiHitbox.SetActive(false);
       // lowHitbox.SetActive(true);
    }

    void Update()
    {
        HitBoxSwap();
    }


    
    IEnumerator HitBoxSwap()
    {
        lowHitbox.SetActive(true);
        hiHitbox.SetActive(false);

        yield return new WaitForSeconds(1f);

        lowHitbox.SetActive(false);
        hiHitbox.SetActive(true);

        yield return new WaitForSeconds(1f);
        lowHitbox.SetActive(true);
        hiHitbox.SetActive(false);

        yield return null;
    }










}
