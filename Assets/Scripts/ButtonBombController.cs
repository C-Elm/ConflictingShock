using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBombController : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;

    public GameObject DefuseImage;
    public GameObject RadialManager;

    private bool doorOpen = false;

    [SerializeField] private string openAnimationName = "BombOpen";
    [SerializeField] private string closeAnimationName = "BombClose";

    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteractoin = false;

    private IEnumerator PauseDoorInteraction()
    {
        pauseInteractoin = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteractoin = false;
    }

    public void PlayAnimation()
    {
        //if (!doorOpen && !pauseInteractoin)
        //{
        //    doorAnim.Play(openAnimationName, 0, 0.0f);
        //    doorOpen = true;
        //    StartCoroutine(PauseDoorInteraction());
        //}

        //else if (doorOpen && !pauseInteractoin)
        //{
        //    doorAnim.Play(closeAnimationName, 0, 0.0f);
        //    doorOpen = false;
        //    StartCoroutine(PauseDoorInteraction());
        //}

        //DefuseImage.SetActive(true);
        //RadialManager.SetActive(true);
    }
}
