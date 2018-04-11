using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteCause : MonoBehaviour
{
  public GameObject nameField;

  private string charName;

  public static WriteCause Instance;

  // Use this for initialization
  void Awake()
  {
    Instance = this;
  }
	
  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Return) && nameField.activeInHierarchy == true)
      {
        if (nameField.GetComponent<InputField>().text == CasualityManager.Instance.selectedCasuality.name)
          {
            ScoreManager.validerReponse();
          }
        GameManager.Instance.EndRound();
      }

    if (Input.GetKeyDown(KeyCode.Return) && nameField.activeInHierarchy != true)
      {
        nameField.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
      }
  }
}
