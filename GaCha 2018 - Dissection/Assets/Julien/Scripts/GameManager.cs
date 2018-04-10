using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  public static GameManager Instance;

  public string CardScene;

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

  public void EndRound()
  {
    Cursor.lockState = CursorLockMode.None;
    SceneManager.LoadScene(CardScene, LoadSceneMode.Single);
  }

  public void EndMatch()
  {

  }
}
