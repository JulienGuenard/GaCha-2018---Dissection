using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSound : MonoBehaviour
{

    public List<AudioClip> sfxList = new List<AudioClip>();
    public List<AudioClip> tombeList = new List<AudioClip>();


    void RandomSound() // Si le joueur fait un perfect depuis au moins 2 Minutes, l'intimide
    {
        if (GetComponent<AudioSource>().isPlaying)
            return;
        GetComponent<AudioSource>().clip = sfxList[Random.Range(0, 4)];
        GetComponent<AudioSource>().Play();
    }

    void RandomSoundSol() // Si le joueur fait un perfect depuis au moins 2 Minutes, l'intimide
    {
        GetComponent<AudioSource>().clip = tombeList[Random.Range(0, 4)];
        GetComponent<AudioSource>().Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("a");
        if (collision.transform.tag == "Os")
        {
            RandomSound();
        }
        if (collision.transform.name == "Sol")
        {
            RandomSoundSol();
        }
    }
}
