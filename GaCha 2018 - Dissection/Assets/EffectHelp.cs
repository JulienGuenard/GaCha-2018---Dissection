using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectHelp : MonoBehaviour
{

  public GameObject indiceItem;
  public Material lastMat;
  public Renderer objRenderer;

  public Material artere_silhouette;
  public Material organe_silhouette;
  public Material os_silhouette;
  public Material tool_silhouette;

  public GameObject UIHelp;

  // Use this for initialization
  void Start()
  {
    EventHelp.help += SelectIndice;
  }

  void SelectIndice()
  {
    activateOutline(indiceItem);
  }

  void activateOutline(GameObject obj)
  {
    Material[] mats;
    //        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
    //        Debug.Log(hit.transform.gameObject);
    objRenderer = obj.transform.GetComponent<Renderer>();
    mats = objRenderer.materials;

    //Here, you have to assign with the exact order!
    if (obj.transform.CompareTag("Artere") == true)
      {
        mats[0] = artere_silhouette;
      }
        //Here, you have to assign with the exact order!
        else if (obj.transform.CompareTag("Organe") == true)
      {
        mats[0] = organe_silhouette;
      }
        //Here, you have to assign with the exact order!
        else if (obj.transform.CompareTag("Os") == true)
      {
        mats[0] = os_silhouette;
      } else if (obj.transform.CompareTag("Tool") == true)
      {
        mats[0] = tool_silhouette;
      }
  }
}
