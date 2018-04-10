using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

  public int maxTime;
  int actualTime;
  Text textTime;

  // Use this for initialization
  void Awake()
  {
    actualTime = maxTime;
    textTime = GetComponent<Text>();
    textTime.text = actualTime.ToString();
    StartCoroutine(Decompte()); 
  }
	
  // Update is called once per frame
  void Update()
  {
    if (actualTime <= 0)
      GameManager.Instance.EndRound();
  }

  IEnumerator Decompte()
  {
    actualTime--;
    float actualTimeMinute = 0;
    float actualTimeSeconde = 0;
    int y = 0;
    for (int i = 0; i < actualTime; i++)
      {
        y++;
        actualTimeSeconde++;
        if (y == 60)
          {
            y = 0;
            actualTimeSeconde = 0;
            actualTimeMinute++;
          }
      }
    textTime.text = actualTimeMinute.ToString() + ":" + actualTimeSeconde.ToString();
    yield return new WaitForSeconds(1f);
    StartCoroutine(Decompte()); 
  }
}
