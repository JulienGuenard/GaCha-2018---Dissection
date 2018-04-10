using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour {

    public static string team1;
    public static string team1Perso;
    public static int team1Score;

    public static string team2;
    public static string team2Perso;
    public static int team2Score;

    public static string team3;
    public static string team3Perso;
    public static int team3Score;

    public static string team4;
    public static string team4Perso;
    public static int team4Score;

    public static string team5;
    public static string team5Perso;
    public static int team5Score;

    public static int conteurdeTour;

    public InputField n1;
	public InputField n2;
	public InputField n3;
	public InputField n4;
	public InputField n5;

	public void lancer() {
		if (n1.text != "" && n2.text != "" && n3.text != "" && n4.text != "" && n5.text != "") {
			Debug.Log ("gg go jouer");
			team1 = n1.text;
			team2 = n2.text;
			team3 = n3.text;
			team4 = n4.text;
			team5 = n5.text;
			Buttons.CustomizationMenu();
		} else {
			Debug.Log ("raté gros noob");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
