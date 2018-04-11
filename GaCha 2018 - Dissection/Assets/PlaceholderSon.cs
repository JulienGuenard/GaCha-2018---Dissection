using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderSon : MonoBehaviour {

    public List<AudioClip> sfxList = new List<AudioClip>();

	// Use this for initialization
	void Start () {
        StartCoroutine(RandomSound());
	}

    IEnumerator RandomSound() // Si le joueur fait un perfect depuis au moins 2 Minutes, l'intimide
    {
        GetComponent<AudioSource>().clip = sfxList[Random.Range(0, 4)];
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3);
        StartCoroutine(RandomSound());
    }
}
