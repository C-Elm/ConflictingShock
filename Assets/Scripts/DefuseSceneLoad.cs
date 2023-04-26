using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefuseSceneLoad : MonoBehaviour
{

    public float delay = 2f;
    public float countdown;


    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            SceneManager.LoadScene("BombDefuse");
        }
    }
}
