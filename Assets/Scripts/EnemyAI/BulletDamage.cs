using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDamage : MonoBehaviour
{
    public float damageAmount = 10;

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    Health currentHealth = collision.gameObject.GetComponent<Health>();
        //    currentHealth.TakeDamage(damageAmount);
        //}

        if(collision.gameObject.TryGetComponent(out Health currentHealth))
        {
            currentHealth.TakeDamage(damageAmount);
           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.TryGetComponent(out Health currentHealth))
        {
            currentHealth.TakeDamage(damageAmount);
 
        }
    }
}
