using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffect : MonoBehaviour
{

    public bool validated;
    public string nameToCheck;


    // Use this for initialization
    void Start()
    {
        if (name == "Peste1")
        {
            Validate();
            EventTremblement.erreur += UnValidate;
        }
        if (name == "Peste2")
        {
            nameToCheck = "Estomac";
            EventPose.pose += CheckName;
        }
        if (name == "Peste3")
        {
            WaitBeforeEnd();
        }

        if (name == "Peste4")
        {
            nameToCheck = "Thyroide";
            EventPose.pose += CheckName;
        }
    }

    void Validate()
    {
        validated = true;
    }

    void UnValidate()
    {
        validated = false;
    }

    void CheckName(string candidateName)
    {
        if(candidateName == nameToCheck)
        {
            Validate();
        }
    }

    IEnumerator WaitBeforeEnd()
    {
        yield return new WaitForSeconds(160);
        UnValidate();
    }

}
