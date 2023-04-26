using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    public float delay = 5f;

    public GameObject explosionEffect;
    public GameObject explosionEffect2;
    public GameObject explosionEffect3;

    float countdown;
    bool hasExploded = false;

    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Instantiate(explosionEffect2, transform.position, transform.rotation);
        Instantiate(explosionEffect3, transform.position, transform.rotation);

        Destroy(gameObject);
    }


}
