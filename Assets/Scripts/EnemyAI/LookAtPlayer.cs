using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject Player;

    Vector2 dir;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = Player.transform.position;

        dir = targetPos - (Vector2)transform.position;

        transform.right = dir;
    }
}
