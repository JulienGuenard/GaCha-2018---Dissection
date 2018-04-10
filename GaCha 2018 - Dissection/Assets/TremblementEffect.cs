using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TremblementEffect : MonoBehaviour {

    bool Tremblemement;

	// Use this for initialization
	void Start () {
        EventTremblement.erreur += StartTremblement;

    }

    void StartTremblement()
    {
        StartCoroutine(Tremblement());
    }

    IEnumerator Tremblement()
    {
        Tremblemement = true;
        yield return new WaitForSeconds(10f);
        Tremblemement = false;
    }

    // Update is called once per frame
    void FixedUpdate () {
        transform.position += new Vector3(Random.Range(-0.01f, 0.01f), 0, Random.Range(-0.01f, 0.01f));
    }
}
