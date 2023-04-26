using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombExplode : MonoBehaviour
{
    public float delay2 = 35f;
    public float countdown2;


    // Start is called before the first frame update
    void Start()
    {
        countdown2 = delay2;
    }

    // Update is called once per frame
    void Update()
    {
        countdown2 -= Time.deltaTime;
        if (countdown2 <= 0f)
        {
            SceneManager.LoadScene("BombExplode");
        }
    }
}
