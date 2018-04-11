using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPose : MonoBehaviour {

    public static System.Action<string> pose;

    void OnTriggerEnter(Collider col)
    {
        pose(col.transform.name);
    }
}
