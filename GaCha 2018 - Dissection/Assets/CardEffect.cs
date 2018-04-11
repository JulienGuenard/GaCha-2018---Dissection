using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffect : MonoBehaviour
{

    public bool validated;
    public string nameToCheck;
    public int nbDecoupes;
    public int maxDecoupes;
    public float maxTimeLeft;

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
            maxTimeLeft = 20;
            GameManager.endRound += checkRoundTime;
        }

        if (name == "Peste4")
        {
            nameToCheck = "Thyroide";
            EventPose.pose += CheckName;
        }

        if (name == "Peste5")
        {
            maxDecoupes = 10;
            HandController.prelevement += IncrementNbMove;
        }

        if (name == "Peste6")
        {
            nameToCheck = "Diaphragme";
            EventPose.pose += CheckName;
        }
        if (name == "Syphilis1")
        {
            nameToCheck = "Estomac";
            EventPose.pose += CheckName;
        }
        if (name == "Syphilis2")
        {
            nameToCheck = "Estomac";
            EventPose.pose += CheckName;
        }
        if (name == "Syphilis3")
        {
            GameManager.endRound += checkRoundTime;
        }

        if (name == "Syphilis4")
        {
            nameToCheck = "Thyroide";
            EventPose.pose += CheckName;
        }

        if (name == "Syphilis5")
        {
        }

        if (name == "Syphilis6")
        {
            nameToCheck = "Diaphragme";
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
        if (candidateName == nameToCheck)
        {
            Validate();
        }
    }

    void IncrementNbMove()
    {
        nbDecoupes++;
        if(nbDecoupes >= maxDecoupes)
        {
            UnValidate();
        }
    }

    void checkRoundTime(float timeLeft)
    {
        if(timeLeft >= maxTimeLeft)
        {
            Validate();
        }
    }

}
