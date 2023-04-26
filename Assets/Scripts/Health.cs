using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    public GameObject bloodEffect;
    public GameObject bloodEffect2;
    public GameObject bloodEffect3;
    public GameObject bloodEffect4;
    public GameObject bloodEffect5;






    void Start()
    {
        currentHealth = maxHealth;
    }
       
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
        }

        if(currentHealth <= 80)
        {
            bloodEffect.SetActive(true);
        }

        if (currentHealth <= 60)
        {
            bloodEffect2.SetActive(true);
        }

        if (currentHealth <= 40)
        {
            bloodEffect3.SetActive(true);
        }

        if (currentHealth <= 20)
        {
            bloodEffect4.SetActive(true);
        }

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("BombExplode");
        }

    }
}
