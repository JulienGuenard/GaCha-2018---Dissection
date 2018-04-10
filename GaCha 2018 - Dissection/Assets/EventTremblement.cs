using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTremblement : MonoBehaviour {

    public static System.Action erreur;

    void OnTriggerEnter(Collider other)
    {
        erreur();
    }

}
