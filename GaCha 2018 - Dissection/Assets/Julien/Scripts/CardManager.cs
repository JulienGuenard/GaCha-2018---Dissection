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
    public Button valider;
    private int compteur;

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

    private void Update()
    {
        Button validation = valider.GetComponent<Button>();

        if(compteur == 4)
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
    listSelectedCard.Add(card);
    card.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
    card.GetComponent<UnityEngine.UI.Button>().enabled = false;
        compteur += 1;
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
        maladie = Random.Range(1,6);
        Debug.Log(maladie);
        if(maladie == 1)
        {

            Image cardimage1 = listCard[0].GetComponent<Image>();
            cardimage1.sprite = ScriptableCardList[0].imageCard;

            listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[0].description;
            listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[0].score.ToString() + " points";

            Image cardimage2 = listCard[1].GetComponent<Image>();
            cardimage2.sprite = ScriptableCardList[1].imageCard;

            listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[1].description;
            listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[1].score.ToString() + " points";

            Image cardimage3 = listCard[2].GetComponent<Image>();
            cardimage3.sprite = ScriptableCardList[2].imageCard;

            listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[2].description;
            listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[2].score.ToString() + " points";

            Image cardimage4 = listCard[3].GetComponent<Image>();
            cardimage4.sprite = ScriptableCardList[3].imageCard;

            listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[3].description;
            listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[3].score.ToString() + " points";

            Image cardimage5 = listCard[4].GetComponent<Image>();
            cardimage5.sprite = ScriptableCardList[4].imageCard;

            listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[4].description;
            listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[4].score.ToString() + " points";

            Image cardimage6 = listCard[5].GetComponent<Image>();
            cardimage6.sprite = ScriptableCardList[5].imageCard;

            listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[5].description;
            listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[5].score.ToString() + " points";
        }
        if(maladie == 2)
        {
            Image cardimage1 = listCard[0].GetComponent<Image>();
            cardimage1.sprite = ScriptableCardList[6].imageCard;

            listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[6].description;
            listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[6].score.ToString() + " points";

            Image cardimage2 = listCard[1].GetComponent<Image>();
            cardimage2.sprite = ScriptableCardList[7].imageCard;

            listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[7].description;
            listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[7].score.ToString() + " points";

            Image cardimage3 = listCard[2].GetComponent<Image>();
            cardimage3.sprite = ScriptableCardList[8].imageCard;

            listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[8].description;
            listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[8].score.ToString() + " points";

            Image cardimage4 = listCard[3].GetComponent<Image>();
            cardimage4.sprite = ScriptableCardList[9].imageCard;

            listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[9].description;
            listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[9].score.ToString() + " points";

            Image cardimage5 = listCard[4].GetComponent<Image>();
            cardimage5.sprite = ScriptableCardList[10].imageCard;

            listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[10].description;
            listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[10].score.ToString() + " points";

            Image cardimage6 = listCard[5].GetComponent<Image>();
            cardimage6.sprite = ScriptableCardList[11].imageCard;

            listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[11].description;
            listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[11].score.ToString() + " points";
        }
        if(maladie == 3)
        {
            Image cardimage1 = listCard[0].GetComponent<Image>();
            cardimage1.sprite = ScriptableCardList[12].imageCard;

            listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[12].description;
            listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[12].score.ToString() + " points";

            Image cardimage2 = listCard[1].GetComponent<Image>();
            cardimage2.sprite = ScriptableCardList[13].imageCard;

            listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[13].description;
            listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[13].score.ToString() + " points";

            Image cardimage3 = listCard[2].GetComponent<Image>();
            cardimage3.sprite = ScriptableCardList[14].imageCard;

            listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[14].description;
            listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[14].score.ToString() + " points";

            Image cardimage4 = listCard[3].GetComponent<Image>();
            cardimage4.sprite = ScriptableCardList[15].imageCard;

            listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[15].description;
            listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[15].score.ToString() + " points";

            Image cardimage5 = listCard[4].GetComponent<Image>();
            cardimage5.sprite = ScriptableCardList[16].imageCard;

            listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[16].description;
            listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[16].score.ToString() + " points";

            Image cardimage6 = listCard[5].GetComponent<Image>();
            cardimage6.sprite = ScriptableCardList[17].imageCard;

            listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[17].description;
            listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[17].score.ToString() + " points";
        }
        if(maladie == 4)
        {
            Image cardimage1 = listCard[0].GetComponent<Image>();
            cardimage1.sprite = ScriptableCardList[18].imageCard;

            listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[18].description;
            listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[18].score.ToString() + " points";

            Image cardimage2 = listCard[1].GetComponent<Image>();
            cardimage2.sprite = ScriptableCardList[19].imageCard;

            listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[19].description;
            listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[19].score.ToString() + " points";

            Image cardimage3 = listCard[2].GetComponent<Image>();
            cardimage3.sprite = ScriptableCardList[20].imageCard;

            listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[20].description;
            listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[20].score.ToString() + " points";

            Image cardimage4 = listCard[3].GetComponent<Image>();
            cardimage4.sprite = ScriptableCardList[21].imageCard;

            listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[21].description;
            listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[21].score.ToString() + " points";

            Image cardimage5 = listCard[4].GetComponent<Image>();
            cardimage5.sprite = ScriptableCardList[22].imageCard;

            listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[22].description;
            listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[22].score.ToString() + " points";

            Image cardimage6 = listCard[5].GetComponent<Image>();
            cardimage6.sprite = ScriptableCardList[23].imageCard;

            listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[23].description;
            listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[23].score.ToString() + " points";
        }
        if(maladie == 5)
        {
            Image cardimage1 = listCard[0].GetComponent<Image>();
            cardimage1.sprite = ScriptableCardList[24].imageCard;

            listCard[0].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[24].description;
            listCard[0].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[24].score.ToString() + " points";

            Image cardimage2 = listCard[1].GetComponent<Image>();
            cardimage2.sprite = ScriptableCardList[25].imageCard;

            listCard[1].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[25].description;
            listCard[1].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[25].score.ToString() + " points";

            Image cardimage3 = listCard[2].GetComponent<Image>();
            cardimage3.sprite = ScriptableCardList[26].imageCard;

            listCard[2].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[26].description;
            listCard[2].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[26].score.ToString() + " points";

            Image cardimage4 = listCard[3].GetComponent<Image>();
            cardimage4.sprite = ScriptableCardList[27].imageCard;

            listCard[3].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[27].description;
            listCard[3].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[27].score.ToString() + " points";

            Image cardimage5 = listCard[4].GetComponent<Image>();
            cardimage5.sprite = ScriptableCardList[28].imageCard;

            listCard[4].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[28].description;
            listCard[4].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[28].score.ToString() + " points";

            Image cardimage6 = listCard[5].GetComponent<Image>();
            cardimage6.sprite = ScriptableCardList[29].imageCard;

            listCard[5].gameObject.transform.GetChild(1).GetComponent<Text>().text = ScriptableCardList[29].description;
            listCard[5].gameObject.transform.GetChild(0).GetComponent<Text>().text = ScriptableCardList[29].score.ToString() + " points";
        }
    }

}
