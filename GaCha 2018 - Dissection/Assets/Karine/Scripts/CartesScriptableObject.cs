﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCarte", menuName = "CreateCard", order = 1)]
public class CartesScriptableObject : ScriptableObject
{
  // info
  public int id;
  public string description;
  public int score;
  public Sprite imageCard;
  public int tailleText;

  // conditions
  public string nameOrgane;
}
