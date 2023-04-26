using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;

    public GameObject Enemy;

    public Component Collider;
    public Component Collider2;
    public Component EnemyScript;
    public Component EnemyScript2;

    void Update()
    {
        Die();
    }

    public void Die()
    {
        if(health <= 0)
        {

            Destroy(Collider);
            Destroy(Collider2);
            Destroy(EnemyScript);
            Destroy(EnemyScript2);
            //Destroy(transform.parent.gameObject);
            Enemy.GetComponent<Animator>().Play("Death");


        }
    }
}
