using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHelp : MonoBehaviour {

    public static System.Action help;
    public static System.Action dontHelp;
    public bool waitForHelp;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(Help());
        waitForHelp = true;
        dontHelp += donotHelp;
    }

    void donotHelp()
    {
        waitForHelp = false;
    }

    IEnumerator Help()
    {
        yield return new WaitForSeconds(120f);
        if(waitForHelp == true)
        {
            help();
        }
    }
}
