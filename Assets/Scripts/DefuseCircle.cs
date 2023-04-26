using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DefuseCircle : MonoBehaviour
{
    public AudioSource source;

    public bool defused = false;

    public GameObject DefuseSceneLoader;
    public GameObject bombSound;
    public GameObject bombButton;
    public GameObject DefuseImage;
    public GameObject RadialManager;
    public Component BombScript;

    [Header("Radial Timers")]
    [SerializeField] private float indicatorTimer = 1.0f;
    [SerializeField] private float maxIndicatorTimer = 1.0f;


    [Header("UI Indicator")]
    [SerializeField] private Image radialIndicatorUI = null;

    [Header("KeyCodes")]
    [SerializeField] private KeyCode selectKey = KeyCode.E;

    [Header("Unity Event")]
    [SerializeField] private UnityEvent myEvent = null;

    private bool shouldUpdate = false;

    private void Update()
    {
        if (Input.GetKey(selectKey))
        {
            shouldUpdate = false;
            indicatorTimer -= Time.deltaTime / 3;
            radialIndicatorUI.enabled = true;
            radialIndicatorUI.fillAmount = indicatorTimer;

            if(indicatorTimer <= 0)
            {
                indicatorTimer = maxIndicatorTimer;
                radialIndicatorUI.fillAmount = maxIndicatorTimer;
                radialIndicatorUI.enabled = false;
                myEvent.Invoke();
                source.Play();
                Destroy(BombScript);
                Destroy(bombButton);
                DefuseImage.SetActive(false);
                RadialManager.SetActive(false);
                Destroy(bombSound);
                DefuseSceneLoader.SetActive(true);

            }



        }
        else
        {
            if (shouldUpdate)
            {
                indicatorTimer += Time.deltaTime;
                radialIndicatorUI.fillAmount = indicatorTimer;

                if (indicatorTimer >= maxIndicatorTimer)
                {
                    indicatorTimer = maxIndicatorTimer;
                    radialIndicatorUI.fillAmount = maxIndicatorTimer;
                    radialIndicatorUI.enabled = false;
                    shouldUpdate = false;
                }
            }
        }

        if (Input.GetKeyUp(selectKey))
        {
            shouldUpdate = true;
        }

    }
}
