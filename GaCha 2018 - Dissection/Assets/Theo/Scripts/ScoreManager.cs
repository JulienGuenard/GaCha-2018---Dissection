﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
  public static int scoreTeam1 = 0;
  public static int scoreTeam2 = 0;
  public static int scoreTeam3 = 0;
  public static int scoreTeam4 = 0;
  public static int scoreTeam5 = 0;

  public static string maladie = "Test";

  public Color color;
  public int number;

  public static InputField reponse;

  public static ScoreManager Instance;

  public GameObject feedbackScore;

  void Awake()
  {
    Instance = this;
  }

  public static void validerReponse()
  {
    if (reponse.text.ToUpper() == maladie.ToUpper())
      {
        switch (NameManager.cptTours)
          {
          case 1: 
            scoreTeam1 += 20;
            break;
          case 2: 
            scoreTeam2 += 20;
            break;
          case 3: 
            scoreTeam3 += 20;
            break;
          case 4: 
            scoreTeam4 += 20;
            break;
          case 5: 
            scoreTeam5 += 20;
            break;
          }
      } else
      {
        switch (NameManager.cptTours)
          {
          case 1: 
            scoreTeam1 -= 10;
            break;
          case 2: 
            scoreTeam2 -= 10;
            break;
          case 3: 
            scoreTeam3 -= 10;
            break;
          case 4: 
            scoreTeam4 -= 10;
            break;
          case 5: 
            scoreTeam5 -= 10;
            break;
          }
      }

    if (NameManager.cptTours == 5)
      {
        Buttons.FinalScore();
      } else
      {
        NameManager.cptTours++;
        Buttons.CustomizationMenuButton();
      }
  }

  public void MarquerPoints(int score)
  {
    StartCoroutine(feedbackON(score, Color.green));
    switch (NameManager.cptTours)
      {
      case 1: 
        scoreTeam1 += score;
        break;
      case 2: 
        scoreTeam2 += score;
        break;
      case 3: 
        scoreTeam3 += score;
        break;
      case 4: 
        scoreTeam4 += score;
        break;
      case 5: 
        scoreTeam5 += score;
        break;
      }
  }

  public void PerdrePoints(int score)
  {
    StartCoroutine(feedbackON(score, Color.red));

    switch (NameManager.cptTours)
      {
      case 1: 
        scoreTeam1 -= score;
        break;
      case 2: 
        scoreTeam2 -= score;
        break;
      case 3: 
        scoreTeam3 -= score;
        break;
      case 4: 
        scoreTeam4 -= score;
        break;
      case 5: 
        scoreTeam5 -= score;
        break;
      }
  }

  public IEnumerator feedbackON(int number, Color color)
  {    
    feedbackScore.GetComponent<TextMesh>().text = "+" + number;
    feedbackScore.GetComponent<TextMesh>().color = color;

    feedbackScore.SetActive(true);
    yield return new WaitForSeconds(1f);
    feedbackScore.SetActive(false);
  }

  public void CardFeedbackON(Color color, int id)
  {    
    Debug.Log(id);
    GameManager.Instance.listCardFeedback[id].color = color;
  }
}

