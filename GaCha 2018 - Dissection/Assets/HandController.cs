using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{

  GameObject selectedObj;

  void Update()
  {
    if (selectedObj != null && Input.GetKeyDown(KeyCode.Mouse0))
      {
        selectedObj.GetComponent<Rigidbody>().useGravity = true;
        selectedObj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        DeselectdArtere(selectedObj);
        selectedObj = null;
      }
  }

  void OnTriggerEnter(Collider col)
  {
    if (col.tag == "Artere")
      {
        if (selectedObj != null)
          {
            DeselectdArtere(selectedObj);
          }
        SelectArtere(col.gameObject);
      }
  }

  void OnTriggerExit(Collider col)
  {
    if (col.tag == "Artere")
      {
        if (selectedObj != null && col.gameObject.name == selectedObj.name)
          {
            DeselectdArtere(col.gameObject);
          }
      }
  }

  void SelectArtere(GameObject obj)
  {
    obj.GetComponent<MeshRenderer>().material.color = Color.yellow;
    selectedObj = obj;
  }

  void DeselectdArtere(GameObject obj)
  {
    selectedObj.GetComponent<MeshRenderer>().material.color = Color.white;
    selectedObj = null;
  }
}
