using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{

  Image img;

  public static FadeManager Instance;

  void Awake()
  {
    if (Instance == null)
      {
        img = GetComponent<Image>();
        DontDestroyOnLoad(this.gameObject);
        Instance = this;
      } else
      {
        Destroy(this.gameObject);
      }
  }

  public void FadeIn()
  {
    StartCoroutine(FadeInCor()); 
  }

  public void FadeOut()
  {
    StartCoroutine(FadeOutCor()); 
  }

  IEnumerator FadeInCor()
  {
    img.color = new Color(0, 0, 0, 0f);
    for (int i = 0; i < 100; i++)
      {
        img.color += new Color(0, 0, 0, 0.01f);
        yield return new WaitForSeconds(1 / 100);
      }
  }

  IEnumerator FadeOutCor()
  {
    img.color = new Color(0, 0, 0, 1f);
    for (int i = 0; i < 100; i++)
      {
        img.color -= new Color(0, 0, 0, 0.01f);
        yield return new WaitForSeconds(1 / 100);
      }
  }
}
