using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;
using UnityEngine.Analytics;

public class HandController : MonoBehaviour
{
  static public System.Action prelevement;

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

  public GameObject selectedObj;
  public GameObject dragObj;
  Material lastMat;
  GameObject hand;
  Transform handPos;
  Transform handDrag;

  SkinnedMeshRenderer skinMesh;
  public Mesh Hand1;
  public Mesh Hand2;
  public Mesh Hand3;

  GameObject DroppedItem;

  Transform offsetRay;

  public List<AudioClip> organeSfxList = new List<AudioClip>();


  void RandomOrganeArracheSound() // Si le joueur fait un perfect depuis au moins 2 Minutes, l'intimide
  {
    // GetComponent<AudioSource>().clip = organeSfxList[Random.Range(0, 4)];
    //   GetComponent<AudioSource>().Play();
  }

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
    DroppedItem = GameObject.Find("DroppedItem");
    offsetRay = GameObject.Find("offsetRay").transform;
  }

  void FixedUpdate()
  {
    // transform.position = handPos.position;
    // MoveToPos();
    RotateHand();


    Debug.DrawRay(offsetRay.position, -offsetRay.up, Color.red, 0.01f);
    Ray ray;
    RaycastHit hit;

    if (Physics.Raycast(offsetRay.position, -offsetRay.up, out hit))
      {
        if (hit.transform.tag == "Artere" || hit.transform.tag == "Os" || hit.transform.tag == "Organe" || hit.transform.tag == "Outil")
          {
            if (selectedObj != null)
              {
                DeselectArtere(selectedObj);
              }
            SelectArtere(hit.transform.gameObject);
          } else
          {
            DeselectArtere(selectedObj);
          }
      } else
      {
        DeselectArtere(selectedObj);

      }

    if (selectedObj != null)
      {
        if (selectedObj.tag != "Artere" && dragObj != null && Input.GetKeyDown(KeyCode.Mouse0) && dragObj.name == "Scalpel")
          {
            EventTaunt.taunt();
            return;
          }

        if (selectedObj.tag != "Os" && dragObj != null && Input.GetKeyDown(KeyCode.Mouse0) && dragObj.name == "Marteau")
          {
            EventTaunt.taunt();
            return;
          }

        if (selectedObj.tag == "Artere" && dragObj != null && Input.GetKeyDown(KeyCode.Mouse0) && dragObj.name == "Scalpel" && selectedObj.GetComponent<Rigidbody>().useGravity == false)
          {
            CutArtere();
            return;
          }

        if (selectedObj.tag == "Os" && dragObj != null && Input.GetKeyDown(KeyCode.Mouse0) && dragObj.name == "Scie" && selectedObj.GetComponent<Rigidbody>().useGravity == false)
          {
            CutOs();
            return;
          }

        if (selectedObj != null && dragObj == null && Input.GetKeyDown(KeyCode.Mouse0))
          {
            Drag();
            return;
          }
      }

    if (dragObj != null)
      {
        if (Input.GetKeyDown(KeyCode.Mouse1))
          {
            Debug.Log(true);
            Drop();
            return;
          }
          
        DragUpdate();
        return;
      }
  }

  void SelectArtere(GameObject obj)
  {
    skinMesh.sharedMesh = Hand2;
    if (obj.transform.GetComponent<Renderer>() != null)
      {
        lastMat = obj.GetComponent<MeshRenderer>().material;
      } else if (obj.transform.GetComponentInChildren<Renderer>() != null)
      {
        lastMat = obj.GetComponentInChildren<MeshRenderer>().material;
      }
    selectedObj = obj;
    if (dragObj == null)
      activateOutline(obj);
  }

  void DeselectArtere(GameObject obj)
  {
    if (obj == null)
      return;
    skinMesh.sharedMesh = Hand1;
    if (selectedObj.transform.GetComponent<Renderer>() != null)
      {
        selectedObj.GetComponent<MeshRenderer>().material = lastMat;
      } else if (selectedObj.transform.GetComponentInChildren<Renderer>() != null)
      {
        selectedObj.GetComponentInChildren<MeshRenderer>().material = lastMat;
      }

    disableOutline(lastTarget);
    selectedObj = null;
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
    if (selectedObj.GetComponent<Rigidbody>() == null)
      return;
      
    if (selectedObj.GetComponent<Rigidbody>().useGravity == true)
      {
        selectedObj.transform.parent = transform; 
        skinMesh.sharedMesh = Hand3;
        dragObj = selectedObj;
        //  dragObj.GetComponent<Rigidbody>().useGravity = false;
        dragObj.GetComponent<Rigidbody>().isKinematic = false;
        CardManager.Instance.CheckOrgane(dragObj.name);
        if (dragObj.tag == "Organe")
          {
            RandomOrganeArracheSound();
          }
      }
  }

  void DragUpdate()
  {
      
    dragObj.transform.position = handDrag.position;
    dragObj.GetComponent<Rigidbody>().velocity = Vector2.zero;
  }

  public void Drop()
  {
    dragObj.transform.parent = DroppedItem.transform; 
    skinMesh.sharedMesh = Hand1;
    //  dragObj.GetComponent<Rigidbody>().useGravity = true;
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
    if (obj.transform.GetComponent<Renderer>() != null)
      {
        materialRenderer = obj.transform.GetComponent<Renderer>();
      } else if (obj.transform.GetComponentInChildren<Renderer>() != null)
      {
        materialRenderer = obj.transform.GetComponentInChildren<Renderer>();
      }

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
      } else if (obj.transform.CompareTag("Outil") == true)
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
      } else if (lastTarget.transform.CompareTag("Outil") == true)
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
