using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
  public string SurgeonScene;
  public List<GameObject> listCard;
  public List<GameObject> listSelectedCard;

  public static CardManager Instance;

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
  }

  void Update()
  {
    if (SceneManager.GetActiveScene().name != SurgeonScene)
      GoSurgeon();
  }

  public void ClearList()
  {
    listSelectedCard.Clear();
  }

  public void AddCard(GameObject card)
  {
    listSelectedCard.Add(card);
    card.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
    card.GetComponent<UnityEngine.UI.Button>().enabled = false;
  }

  void GoSurgeon()
  {
    if (listSelectedCard.Count > 3)
      {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SurgeonScene, LoadSceneMode.Single);
      }
  }
}
