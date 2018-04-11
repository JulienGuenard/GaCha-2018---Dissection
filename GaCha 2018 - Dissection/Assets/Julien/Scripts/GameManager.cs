using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(endRound != null)
        endRound(timer.maxTime - timer.actualTime);
        Cursor.lockState = CursorLockMode.None;
    SceneManager.LoadScene(CardScene, LoadSceneMode.Single);
        NameManager.cptTours++;
  }

  public void EndMatch()
  {

  }
}
