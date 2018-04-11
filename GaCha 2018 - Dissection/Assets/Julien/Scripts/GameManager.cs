using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  //EventPose
  //EventHelp
  //EventTaunt
  //EventTremblement
  //EventDeconcentrate
  //HandController
  //

  public static GameManager Instance;
  public static System.Action<float> endRound;

  public string CardScene;
  public Timer timer;

  public List<Text> listCardFeedback;

  void Awake()
  {
    if (Instance == null)
      {
        DontDestroyOnLoad(this.gameObject);
        Instance = this;
      } else
      {
        Destroy(this.gameObject);
      }	

    if (CardManager.Instance != null && CardManager.Instance.listSelectedCard.Count != 0)
      ShowCard();
  }

  void ShowCard()
  {
    for (int i = 0; i < 4; i++)
      {
        listCardFeedback[i].text = CardManager.Instance.listSelectedCard[i].description;
      }
  }

  public void EndRound()
  {
    if (endRound != null)
      endRound(timer.maxTime - timer.actualTime);
    Cursor.lockState = CursorLockMode.None;
    SceneManager.LoadScene(CardScene, LoadSceneMode.Single);
    NameManager.cptTours++;
  }

  public void EndMatch()
  {

  }
}
