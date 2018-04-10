using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suisobj : MonoBehaviour {

    public Transform a;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = a.position;
	}
}
