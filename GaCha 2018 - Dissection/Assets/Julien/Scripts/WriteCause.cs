using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

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
        GameManager.Instance.EndRound();
      }

    if (Input.GetKeyDown(KeyCode.Return) && nameField.activeInHierarchy != true)
      {
        nameField.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
      }

  }
}
