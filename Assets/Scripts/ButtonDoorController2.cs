using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorController2 : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;

    private bool doorOpen = false;

    [SerializeField] private string openAnimationName = "GarageDoorOpen";
    [SerializeField] private string closeAnimationName = "GarageDoorClose";

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
        if (!doorOpen && !pauseInteractoin)
        {
            doorAnim.Play(openAnimationName, 0, 0.0f);
            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
        }

        else if (doorOpen && !pauseInteractoin)
        {
            doorAnim.Play(closeAnimationName, 0, 0.0f);
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
        }
    }
}
