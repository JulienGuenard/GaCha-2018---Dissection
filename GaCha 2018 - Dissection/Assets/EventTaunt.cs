using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTaunt : MonoBehaviour {

    public static System.Action taunt;

    void OnTriggerEnter(Collider other)
    {
        taunt();
    }
}
