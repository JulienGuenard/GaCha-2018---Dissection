using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCarte", menuName = "CreateCard", order = 1)]
public class CartesScriptableObject : ScriptableObject {

    public int id;
    public string description;
    public int score;
    public Sprite imageCard;

}
