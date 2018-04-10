using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;

public class HandController : MonoBehaviour
{

  static public GameObject selectedObj;
  Color lastColor;

  void Update()
  {
    if (selectedObj != null && Input.GetKeyDown(KeyCode.Mouse0))
      CutArtere();
  }

  void OnTriggerEnter(Collider col)
  {
    if (col.tag == "Artere" || col.tag == "Os" || col.tag == "Organe")
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
    if (col.tag == "Artere" || col.tag == "Os" || col.tag == "Organe")
      {
        if (selectedObj != null && col.gameObject.name == selectedObj.name)
          {
            DeselectdArtere(col.gameObject);
          }
      }
  }

  void SelectArtere(GameObject obj)
  {
    lastColor = obj.GetComponent<MeshRenderer>().material.color;
    obj.GetComponent<MeshRenderer>().material.color = Color.yellow;
    selectedObj = obj;
  }

  void DeselectdArtere(GameObject obj)
  {
    selectedObj.GetComponent<MeshRenderer>().material.color = lastColor;
    selectedObj = null;
  }

  void CutArtere()
  {
    selectedObj.GetComponent<Rigidbody>().useGravity = true;
    selectedObj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    selectedObj.GetComponentInParent<OrganeData>().listArtere.Remove(selectedObj);
    DeselectdArtere(selectedObj);
    selectedObj = null;
  }
}
