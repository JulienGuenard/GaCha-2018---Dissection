using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganeData : MonoBehaviour
{

  public List<GameObject> listArtere;
  bool isDetached = false;

  Rigidbody rigidbody;

  void Awake()
  {
    rigidbody = GetComponent<Rigidbody>();
  }

  void Update()
  {
    if (listArtere.Count == 0 && !isDetached)
      {
        isDetached = true;
        rigidbody.useGravity = true;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
      }
        
  }
}
