using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTremblement : MonoBehaviour {

    public static System.Action erreur;
    public Timer timer;

    void Start()
    {
        StartCoroutine(FinProche());
    }


    IEnumerator FinProche() // fais un tremblement quand la fin d'une partie est proche
    {
        yield return new WaitForSeconds(timer.maxTime - 6);
        erreur();
    }
}
