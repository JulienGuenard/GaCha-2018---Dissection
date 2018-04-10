using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour{

    public GameObject itemTemp;
    public Transform Hand;

    public GameObject bite;

    private void Start()
    {
       bite = HandController.selectedObj;
        
    }

    public void OnMouseDown()
    {
        
    }
}

