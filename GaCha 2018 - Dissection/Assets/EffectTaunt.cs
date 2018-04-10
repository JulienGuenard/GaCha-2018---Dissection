using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTaunt : MonoBehaviour
{
    public GameObject tnulUI;
    public Timer timer;
    public GameObject midTimeUI;

    public bool midTime;

    // Use this for initialization
    void Start()
    {
        EventTaunt.taunt += StartTaunted;
    }
    void StartTaunted()
    {
        StopAllCoroutines();
        StartCoroutine(Taunted());
    }

    IEnumerator Taunted()
    {
        tnulUI.gameObject.SetActive(true);
        yield return new WaitForSeconds(10f);
        tnulUI.gameObject.SetActive(false);
    }

    void Update()
    {
        if (timer.actualTime <= timer.maxTime /2 && !midTime)
        {
            midTime = true;
            StartCoroutine(MidTimeView());
        }
    }

    IEnumerator MidTimeView()
    {
        midTimeUI.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        midTimeUI.gameObject.SetActive(false);
    }
}
