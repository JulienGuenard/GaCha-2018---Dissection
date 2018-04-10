using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;
using UnityEngine.Analytics;

public class HandController : MonoBehaviour
{
  public float speedRotation;

  static public GameObject selectedObj;
  Color lastColor;
  GameObject hand;
  Transform handPos;

  void Start()
  {
    hand = GameObject.Find("Hand");
    handPos = GameObject.Find("HandPos").transform;
  }

  void FixedUpdate()
  {
    if (selectedObj != null && Input.GetKeyDown(KeyCode.Mouse0))
      CutArtere();

    MoveToPos();
    RotateHand();
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

  void MoveToPos()
  {
    transform.position = handPos.position;
  }

  void RotateHand()
  {
//    Debug.Log(Input.GetAxis("Horizontal") + " " + transform.localRotation.eulerAngles.y);
    if (!(transform.localRotation.eulerAngles.z < 200 && transform.localRotation.eulerAngles.z > 180) && Input.GetAxis("Horizontal") < 0)
      hand.transform.localRotation = Quaternion.Euler(hand.transform.localRotation.eulerAngles.x, hand.transform.localRotation.eulerAngles.y, hand.transform.localRotation.eulerAngles.z + Input.GetAxis("Horizontal") * speedRotation);
  
    if (!(transform.localRotation.eulerAngles.z > 160 && transform.localRotation.eulerAngles.z < 180) && Input.GetAxis("Horizontal") > 0)
      hand.transform.localRotation = Quaternion.Euler(hand.transform.localRotation.eulerAngles.x, hand.transform.localRotation.eulerAngles.y, hand.transform.localRotation.eulerAngles.z + Input.GetAxis("Horizontal") * speedRotation);

    if (!(transform.localRotation.eulerAngles.x < 315 && transform.localRotation.eulerAngles.x > 200) && Input.GetAxis("Vertical") > 0)
      hand.transform.localRotation = Quaternion.Euler(hand.transform.localRotation.eulerAngles.x + -Input.GetAxis("Vertical") * speedRotation, hand.transform.localRotation.eulerAngles.y, 0);
      
    if (!(transform.localRotation.eulerAngles.x > 45 && transform.localRotation.eulerAngles.x < 120) && Input.GetAxis("Vertical") < 0)
      hand.transform.localRotation = Quaternion.Euler(hand.transform.localRotation.eulerAngles.x + -Input.GetAxis("Vertical") * speedRotation, hand.transform.localRotation.eulerAngles.y, 0);
  }
}
