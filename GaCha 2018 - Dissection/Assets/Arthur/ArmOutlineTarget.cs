using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmOutlineTarget : MonoBehaviour {

    public Material artere;
    public Material artere_silhouette;
    public Material organe;
    public Material organe_silhouette;
    public Material os;
    public Material os_silhouette;
    public Renderer materialRenderer;
    public Material[] mats;
    public GameObject lastTarget;

    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
                activateOutline(hit);
        }
    }

    void activateOutline(RaycastHit hit)
    {
        if (lastTarget != null)
        {
            if (lastTarget != hit.transform.gameObject)
                disableOutline(lastTarget);
        }
        //        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        //        Debug.Log(hit.transform.gameObject);
        materialRenderer = hit.transform.GetComponent<Renderer>();
        if (materialRenderer == null)
        {
            disableOutline(lastTarget);
            return;
        }
        mats = materialRenderer.materials;

        //Here, you have to assign with the exact order!
        if (hit.transform.CompareTag("Artere") == true)
        {
            mats[0] = artere_silhouette;
        }
        //Here, you have to assign with the exact order!
        else if (hit.transform.CompareTag("Organe") == true)
        {
            mats[0] = organe_silhouette;
        }
        //Here, you have to assign with the exact order!
        else if (hit.transform.CompareTag("Os") == true)
        {
            mats[0] = os_silhouette;
        }

        materialRenderer.materials = mats;
        lastTarget = hit.transform.gameObject;
    }

    void disableOutline(GameObject lastTarget)
    {
        if(materialRenderer == null)
        {
            return;
        }
        mats = materialRenderer.materials;
        //Here, you have to assign with the exact order!
        if (lastTarget.transform.CompareTag("Artere") == true)
        {
            mats[0] = artere;
        }
        //Here, you have to assign with the exact order!
        else if (lastTarget.transform.CompareTag("Organe") == true)
        {
            mats[0] = organe;
        }
        //Here, you have to assign with the exact order!
        else if (lastTarget.transform.CompareTag("Os") == true)
        {
            mats[0] = os;
        }
        else
        {
            return;
        }

        materialRenderer.materials = mats;
        materialRenderer = null;

    }
}
