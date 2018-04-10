using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDeconcentrate : MonoBehaviour {

    public static System.Action<float> deconcentrate;

    public static System.Action dropItem;

    private void Start()
    {
        EventTremblement.erreur += CheckNoError;
        StartCoroutine(Perfect());
    }

    void CheckNoError()
    {
        StopCoroutine(Perfect());
        StartCoroutine(Perfect());
    }

    IEnumerator Perfect() // Si le joueur fait un perfect depuis au moins 2 Minutes, l'intimide
    {
        yield return new WaitForSeconds(120);
        dropItem();
        StartCoroutine(Perfect());
    }
}
