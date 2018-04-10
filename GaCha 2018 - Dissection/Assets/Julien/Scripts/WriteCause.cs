using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteCause : MonoBehaviour
{
  public InputField nameField;

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
    if (Input.GetKeyDown(KeyCode.Return))
      Debug.Log("a");
  }

  void StringUpdate()
  {
    charName = nameField.text;
     

    //   Debug.
  }

}
