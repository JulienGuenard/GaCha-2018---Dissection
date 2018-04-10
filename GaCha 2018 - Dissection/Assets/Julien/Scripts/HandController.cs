using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;
using UnityEngine.Analytics;

public class HandController : MonoBehaviour
{
  public Material artere;
  public Material artere_silhouette;
  public Material organe;
  public Material organe_silhouette;
  public Material os;
  public Material os_silhouette;
  public Material tool;
  public Material tool_silhouette;
  public Renderer materialRenderer;
  public Material[] mats;
  public GameObject lastTarget;

  public float speedRotation;

  static public GameObject selectedObj;
  public GameObject dragObj;
  Material lastMat;
  GameObject hand;
  Transform handPos;
  Transform handDrag;

  SkinnedMeshRenderer skinMesh;
  public Mesh Hand1;
  public Mesh Hand2;
  public Mesh Hand3;

  public static HandController Instance;

  void Awake()
  {
    Instance = this;
    skinMesh = GameObject.Find("Hand_1").GetComponent<SkinnedMeshRenderer>();
  }

  void Start()
  {
    hand = GameObject.Find("Hand");
//    handPos = GameObject.Find("HandPos").transform;
    handDrag = GameObject.Find("HandDrag").transform;
  }

  void FixedUpdate()
  {
    // transform.position = handPos.position;
    // MoveToPos();
    RotateHand();

    if (selectedObj != null && selectedObj.tag == "Artere" && dragObj != null && Input.GetKeyDown(KeyCode.Mouse0) && dragObj.name == "Scalpel" && selectedObj.GetComponent<Rigidbody>().useGravity == false)
      {
        CutArtere();
        return;
      }

    if (selectedObj != null && selectedObj.tag == "Os" && dragObj != null && Input.GetKeyDown(KeyCode.Mouse0) && dragObj.name == "Scie" && selectedObj.GetComponent<Rigidbody>().useGravity == false)
      {
        CutOs();
        return;
      }

    if (selectedObj != null && dragObj != null && Input.GetKeyDown(KeyCode.Mouse1))
      {
        Drop();
        return;
      }

    if (selectedObj != null && dragObj == null && Input.GetKeyDown(KeyCode.Mouse0))
      {
        Drag();
        return;

      }

    if (dragObj != null)
      {
        DragUpdate();
        return;
      }
  }

  void OnTriggerEnter(Collider col)
  {
    if (col.tag == "Artere" || col.tag == "Os" || col.tag == "Organe" || col.tag == "Tool")
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
    if (col.tag == "Artere" || col.tag == "Os" || col.tag == "Organe" || col.tag == "Tool")
      {
        if (selectedObj != null && col.gameObject.name == selectedObj.name)
          {
            DeselectdArtere(col.gameObject);
          }
      }
  }

  void SelectArtere(GameObject obj)
  {
    skinMesh.sharedMesh = Hand2;
    lastMat = obj.GetComponent<MeshRenderer>().material;
    selectedObj = obj;
    activateOutline(obj);
  }

  void DeselectdArtere(GameObject obj)
  {
    skinMesh.sharedMesh = Hand1;
    selectedObj.GetComponent<MeshRenderer>().material = lastMat;
    //   selectedObj = null;
  }

  void CutArtere()
  {
    selectedObj.GetComponent<Rigidbody>().useGravity = true;
    selectedObj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    if (selectedObj.GetComponentInParent<OrganeData>() != null)
      selectedObj.GetComponentInParent<OrganeData>().listArtere.Remove(selectedObj);

    selectedObj = null;
  }

  void CutOs()
  {
    selectedObj.GetComponent<Rigidbody>().useGravity = true;
    selectedObj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
  }
  
  /*
  void MoveToPos()
  {
    transform.position = handPos.position;
  }*/

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

  void Drag()
  {
    if (selectedObj.GetComponent<Rigidbody>().useGravity == true)
      {
        skinMesh.sharedMesh = Hand3;
        dragObj = selectedObj;
        dragObj.GetComponent<Rigidbody>().useGravity = false;
        
      }
  }

  void DragUpdate()
  {
    dragObj.transform.position = handDrag.position;
  }

  public void Drop()
  {
    skinMesh.sharedMesh = Hand1;
    dragObj.GetComponent<Rigidbody>().useGravity = true;
    dragObj = null;
  }

  void activateOutline(GameObject obj)
  {
    if (lastTarget != null)
      {
        if (lastTarget != obj.transform.gameObject)
          disableOutline(lastTarget);
      }
    //        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
    //        Debug.Log(hit.transform.gameObject);
    materialRenderer = obj.transform.GetComponent<Renderer>();
    if (materialRenderer == null)
      {
        disableOutline(lastTarget);
        return;
      }
    mats = materialRenderer.materials;

    //Here, you have to assign with the exact order!
    if (obj.transform.CompareTag("Artere") == true)
      {
        lastMat = mats[0];
        mats[0] = artere_silhouette;
      }
      //Here, you have to assign with the exact order!
      else if (obj.transform.CompareTag("Organe") == true)
      {
        lastMat = mats[0];
        mats[0] = organe_silhouette;
      }
      //Here, you have to assign with the exact order!
      else if (obj.transform.CompareTag("Os") == true)
      {
        lastMat = mats[0];
        mats[0] = os_silhouette;
      } else if (obj.transform.CompareTag("Tool") == true)
      {
        lastMat = mats[0];
        mats[0] = tool_silhouette;
      }

    materialRenderer.materials = mats;
    lastTarget = obj.transform.gameObject;
  }

  void disableOutline(GameObject lastTarget)
  {
    if (materialRenderer == null)
      {
        return;
      }
    mats = materialRenderer.materials;
    //Here, you have to assign with the exact order!
    if (lastTarget.transform.CompareTag("Artere") == true)
      {
        mats[0] = lastMat;
      }
      //Here, you have to assign with the exact order!
      else if (lastTarget.transform.CompareTag("Organe") == true)
      {
        mats[0] = lastMat;
      }
      //Here, you have to assign with the exact order!
      else if (lastTarget.transform.CompareTag("Os") == true)
      {
        mats[0] = lastMat;
      } else if (lastTarget.transform.CompareTag("Tool") == true)
      {
        mats[0] = lastMat;
      } else
      {
        return;
      }

    materialRenderer.materials = mats;
    materialRenderer = null;

  }
}
