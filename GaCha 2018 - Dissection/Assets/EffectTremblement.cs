using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTremblement : MonoBehaviour
{

  bool Tremblemement;
  public GameObject bras;

  public GameObject UITremblement;

  // Use this for initialization
  void Start()
  {
    EventTremblement.erreur += StartTremblement;
  }

  void StartTremblement()
  {
    StartCoroutine(Tremblement());
  }

  IEnumerator Tremblement()
  {
    Tremblemement = true;
    Debug.Log("Tremblement");
    yield return new WaitForSeconds(10f);
    Tremblemement = false;
  }

  IEnumerator PerfectTremblement() // le joueur est trop bon alors on le fait trembler
  {
    yield return new WaitForSeconds(120);
    StartCoroutine(Tremblement());
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (Tremblemement)
      {
        bras.transform.position += new Vector3(Random.Range(-0.5f, 0.5f), 0, Random.Range(-0.05f, 0.05f));
      }
  }
}
