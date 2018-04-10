using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardEvent : MonoBehaviour
{

  void OnMouseEnter()
  {
    GetComponent<Image>().color = Color.cyan;
  }

  void OnMouseExit()
  {
    GetComponent<Image>().color = Color.white;
  }

  void OnMouseDown()
  {
    CardManager.Instance.AddCard(this.gameObject);
  }
}
