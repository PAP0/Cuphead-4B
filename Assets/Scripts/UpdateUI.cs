using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    [SerializeField] GameObject HP1;
    [SerializeField] GameObject HP2;
    [SerializeField] GameObject HP3;
    void Start()
    {
        
    }
    public void ChangeUI(int currentHealth)
    {
        if(currentHealth == 3){
            HP3.SetActive(true);
            HP2.SetActive(false);
            HP1.SetActive(false);
        } else if(currentHealth == 2){
            HP2.SetActive(true);
            HP1.SetActive(false);
            HP3.SetActive(false);
        }else if(currentHealth == 1){
            HP1.SetActive(true);
            HP2.SetActive(false);
            HP3.SetActive(false);
        }else{
            HP1.SetActive(false);
            HP2.SetActive(false);
            HP3.SetActive(false);
        }
    }
}
