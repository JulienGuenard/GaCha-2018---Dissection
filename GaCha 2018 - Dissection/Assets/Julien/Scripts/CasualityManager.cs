using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasualityManager : MonoBehaviour
{
  public GameObject selectedCasuality;
  public List<GameObject> listCasuality;

  public static CasualityManager Instance;

  // Use this for initialization
  void Awake()
  {
    if (Instance == null)
      {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        SelectNewCasuality();
      } else
      {
        Destroy(this.gameObject);
      }
  }
	
  // Update is called once per frame
  void Update()
  {
		
  }

  void SelectNewCasuality()
  {
    selectedCasuality = listCasuality[Random.Range(0, listCasuality.Count - 1)];
  }

}
