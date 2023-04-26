using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnTriggerEneter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            SceneManager.LoadScene("SampleScene");
    }


}
