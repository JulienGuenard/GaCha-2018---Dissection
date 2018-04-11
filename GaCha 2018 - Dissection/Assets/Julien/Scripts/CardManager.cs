using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
  public string SurgeonScene;
  public List<GameObject> listCard;
  public List<CartesScriptableObject> listSelectedCard;
  public List<CartesScriptableObject> ScriptableCardList;
  private float maladie;
  public Button valider;
  public int compteur;

  Button validation;

  public static CardManager Instance;

  void Awake()
  {
    validation = valider.GetComponent<Button>();
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

  private void Update()
  {
    if (compteur == 4)
      {
        validation.onClick.AddListener(GoSurgeon);
      }
  }

  public void ClearList()
  {
    listSelectedCard.Clear();
  }

  public void AddCard(GameObject card)
  {
    if (compteur > 3)
      return;

    foreach (CartesScriptableObject obj in ScriptableCardList)
      {
        if (obj.name == card.name)
          {
            listSelectedCard.Add(obj);
          }
      }

    card.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
    card.GetComponent<UnityEngine.UI.Button>().enabled = false;
    compteur += 1;
  }

  void GoSurgeon()
  {
    if (listSelectedCard.Count > 1)
      {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SurgeonScene, LoadSceneMode.Single);
      }
  }

  public void DistributionCard()
  {
    maladie = Random.Range(1, 6);
    if (maladie == 1)
      {

        Image cardimage1 = listCard[0].GetComponent<Image>();
        cardimage1.sprite = ScriptableCardList[0].imageCard;

        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[0].description;
        listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[0].score.ToString() + " points";
        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[0].tailleText;
        listCard[0].name = ScriptableCardList[0].name;

        Image cardimage2 = listCard[1].GetComponent<Image>();
        cardimage2.sprite = ScriptableCardList[1].imageCard;

        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[1].description;
        listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[1].score.ToString() + " points";
        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[1].tailleText;
        listCard[1].name = ScriptableCardList[1].name;

        Image cardimage3 = listCard[2].GetComponent<Image>();
        cardimage3.sprite = ScriptableCardList[2].imageCard;

        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[2].description;
        listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[2].score.ToString() + " points";
        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[2].tailleText;
        listCard[2].name = ScriptableCardList[2].name;

        Image cardimage4 = listCard[3].GetComponent<Image>();
        cardimage4.sprite = ScriptableCardList[3].imageCard;

        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[3].description;
        listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[3].score.ToString() + " points";
        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[3].tailleText;
        listCard[3].name = ScriptableCardList[3].name;

        Image cardimage5 = listCard[4].GetComponent<Image>();
        cardimage5.sprite = ScriptableCardList[4].imageCard;

        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[4].description;
        listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[4].score.ToString() + " points";
        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[4].tailleText;
        listCard[4].name = ScriptableCardList[4].name;

        Image cardimage6 = listCard[5].GetComponent<Image>();
        cardimage6.sprite = ScriptableCardList[5].imageCard;

        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[5].description;
        listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[5].score.ToString() + " points";
        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[5].tailleText;
        listCard[5].name = ScriptableCardList[5].name;


      }
    if (maladie == 2)
      {
        Image cardimage1 = listCard[0].GetComponent<Image>();
        cardimage1.sprite = ScriptableCardList[6].imageCard;

        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[6].description;
        listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[6].score.ToString() + " points";
        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[6].tailleText;
        listCard[0].name = ScriptableCardList[6].name;

        Image cardimage2 = listCard[1].GetComponent<Image>();
        cardimage2.sprite = ScriptableCardList[7].imageCard;

        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[7].description;
        listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[7].score.ToString() + " points";
        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[7].tailleText;
        listCard[0].name = ScriptableCardList[7].name;

        Image cardimage3 = listCard[2].GetComponent<Image>();
        cardimage3.sprite = ScriptableCardList[8].imageCard;

        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[8].description;
        listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[8].score.ToString() + " points";
        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[8].tailleText;
        listCard[2].name = ScriptableCardList[8].name;

        Image cardimage4 = listCard[3].GetComponent<Image>();
        cardimage4.sprite = ScriptableCardList[9].imageCard;

        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[9].description;
        listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[9].score.ToString() + " points";
        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[9].tailleText;
        listCard[3].name = ScriptableCardList[9].name;

        Image cardimage5 = listCard[4].GetComponent<Image>();
        cardimage5.sprite = ScriptableCardList[10].imageCard;

        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[10].description;
        listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[10].score.ToString() + " points";
        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[10].tailleText;
        listCard[4].name = ScriptableCardList[10].name;

        Image cardimage6 = listCard[5].GetComponent<Image>();
        cardimage6.sprite = ScriptableCardList[11].imageCard;

        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[11].description;
        listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[11].score.ToString() + " points";
        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[11].tailleText;
        listCard[5].name = ScriptableCardList[11].name;
      }
    if (maladie == 3)
      {
        Image cardimage1 = listCard[0].GetComponent<Image>();
        cardimage1.sprite = ScriptableCardList[12].imageCard;

        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[12].description;
        listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[12].score.ToString() + " points";
        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[12].tailleText;
        listCard[0].name = ScriptableCardList[12].name;

        Image cardimage2 = listCard[1].GetComponent<Image>();
        cardimage2.sprite = ScriptableCardList[13].imageCard;

        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[13].description;
        listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[13].score.ToString() + " points";
        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[13].tailleText;
        listCard[0].name = ScriptableCardList[13].name;

        Image cardimage3 = listCard[2].GetComponent<Image>();
        cardimage3.sprite = ScriptableCardList[14].imageCard;

        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[14].description;
        listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[14].score.ToString() + " points";
        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[14].tailleText;
        listCard[2].name = ScriptableCardList[14].name;

        Image cardimage4 = listCard[3].GetComponent<Image>();
        cardimage4.sprite = ScriptableCardList[15].imageCard;

        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[15].description;
        listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[15].score.ToString() + " points";
        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[15].tailleText;
        listCard[3].name = ScriptableCardList[15].name;

        Image cardimage5 = listCard[4].GetComponent<Image>();
        cardimage5.sprite = ScriptableCardList[16].imageCard;

        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[16].description;
        listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[16].score.ToString() + " points";
        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[16].tailleText;
        listCard[4].name = ScriptableCardList[16].name;

        Image cardimage6 = listCard[5].GetComponent<Image>();
        cardimage6.sprite = ScriptableCardList[17].imageCard;

        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[17].description;
        listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[17].score.ToString() + " points";
        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[17].tailleText;
        listCard[5].name = ScriptableCardList[17].name;
      }
    if (maladie == 4)
      {
        Image cardimage1 = listCard[0].GetComponent<Image>();
        cardimage1.sprite = ScriptableCardList[18].imageCard;

        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[18].description;
        listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[18].score.ToString() + " points";
        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[18].tailleText;
        listCard[0].name = ScriptableCardList[18].name;

        Image cardimage2 = listCard[1].GetComponent<Image>();
        cardimage2.sprite = ScriptableCardList[19].imageCard;

        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[19].description;
        listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[19].score.ToString() + " points";
        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[19].tailleText;
        listCard[1].name = ScriptableCardList[19].name;

        Image cardimage3 = listCard[2].GetComponent<Image>();
        cardimage3.sprite = ScriptableCardList[20].imageCard;

        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[20].description;
        listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[20].score.ToString() + " points";
        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[20].tailleText;
        listCard[2].name = ScriptableCardList[20].name;

        Image cardimage4 = listCard[3].GetComponent<Image>();
        cardimage4.sprite = ScriptableCardList[21].imageCard;

        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[21].description;
        listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[21].score.ToString() + " points";
        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[21].tailleText;
        listCard[3].name = ScriptableCardList[21].name;

        Image cardimage5 = listCard[4].GetComponent<Image>();
        cardimage5.sprite = ScriptableCardList[22].imageCard;

        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[22].description;
        listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[22].score.ToString() + " points";
        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[22].tailleText;
        listCard[4].name = ScriptableCardList[22].name;

        Image cardimage6 = listCard[5].GetComponent<Image>();
        cardimage6.sprite = ScriptableCardList[23].imageCard;

        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[23].description;
        listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[23].score.ToString() + " points";
        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[23].tailleText;
        listCard[5].name = ScriptableCardList[23].name;
      }
    if (maladie == 5)
      {
        Image cardimage1 = listCard[0].GetComponent<Image>();
        cardimage1.sprite = ScriptableCardList[24].imageCard;

        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[24].description;
        listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[24].score.ToString() + " points";
        listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[24].tailleText;
        listCard[0].name = ScriptableCardList[24].name;

        Image cardimage2 = listCard[1].GetComponent<Image>();
        cardimage2.sprite = ScriptableCardList[25].imageCard;

        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[25].description;
        listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[25].score.ToString() + " points";
        listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[25].tailleText;
        listCard[1].name = ScriptableCardList[25].name;

        Image cardimage3 = listCard[2].GetComponent<Image>();
        cardimage3.sprite = ScriptableCardList[26].imageCard;

        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[26].description;
        listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[26].score.ToString() + " points";
        listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[26].tailleText;
        listCard[2].name = ScriptableCardList[26].name;

        Image cardimage4 = listCard[3].GetComponent<Image>();
        cardimage4.sprite = ScriptableCardList[27].imageCard;

        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[27].description;
        listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[27].score.ToString() + " points";
        listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[27].tailleText;
        listCard[3].name = ScriptableCardList[27].name;

        Image cardimage5 = listCard[4].GetComponent<Image>();
        cardimage5.sprite = ScriptableCardList[28].imageCard;

        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[28].description;
        listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[28].score.ToString() + " points";
        listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[28].tailleText;
        listCard[4].name = ScriptableCardList[28].name;

        Image cardimage6 = listCard[5].GetComponent<Image>();
        cardimage6.sprite = ScriptableCardList[29].imageCard;

        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[29].description;
        listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[29].score.ToString() + " points";
        listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().fontSize = ScriptableCardList[29].tailleText;
        listCard[5].name = ScriptableCardList[29].name;
      }
  }

  public void CheckOrgane(string nameOrgane)
  {
    foreach (CartesScriptableObject obj in ScriptableCardList)
      {
        foreach (GameObject obj2 in listCard)
          {
            if (obj.name == nameOrgane)
              {
                ScoreManager.MarquerPoints(obj.score);
                listSelectedCard.Remove(obj);
              }
          }
      }
  }
}
