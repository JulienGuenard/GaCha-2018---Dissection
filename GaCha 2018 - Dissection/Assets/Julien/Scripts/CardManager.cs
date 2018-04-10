using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
  public string SurgeonScene;
  public List<GameObject> listCard;
  public List<GameObject> listSelectedCard;
  public List<CartesScriptableObject> ScriptableCardList;
  private float maladie;

    public static CardManager Instance;

  void Awake()
  {
    DistributionCard();
    if (Instance == null)
      {
        DontDestroyOnLoad(this.gameObject);
        Instance = this;
      } else
      {
        Destroy(this.gameObject);
      }
        Debug.Log(ScriptableCardList[0].description);
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


    public void DistributionCard()
    {
        maladie = 1;
        Debug.Log(maladie);
        if(maladie == 1)
        {

            Image cardimage1 = listCard[0].GetComponent<Image>();
            cardimage1.sprite = ScriptableCardList[0].imageCard;

            listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[0].description;
            listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[0].score.ToString() + " points";
        }
        if(maladie == 2)
        {

        }
        if(maladie == 3)
        {

        }
        if(maladie == 4)
        {

        }
        if(maladie == 5)
        {

        }
    }

}
