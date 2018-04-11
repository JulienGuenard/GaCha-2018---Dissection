using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour {

	public static int cptTours = 1;

	public static string team1;
	public static int scoreTeam1 = 0;

	public static string team2;
	public static int scoreTeam2 = 0;

	public static string team3;
	public static int scoreTeam3 = 0;

	public static string team4;
	public static int scoreTeam4 = 0;

	public static string team5;
	public static int scoreTeam5 = 0;


	public void lancerNostra() {
		switch (cptTours) {
		case 1: 
			team1 = "Nostradamus";
			break;
		case 2: 
			team2 = "Nostradamus";
			break;
		case 3: 
			team3 = "Nostradamus";
			break;
		case 4: 
			team4 = "Nostradamus";
			break;
		case 5: 
			team5 = "Nostradamus";
			break;
		}
		Buttons.CardsMenu ();
	}

	public void lancerAndre() {
		switch (cptTours) {
		case 1: 
			team1 = "Nostradamus";
			break;
		case 2: 
			team2 = "Nostradamus";
			break;
		case 3: 
			team3 = "Nostradamus";
			break;
		case 4: 
			team4 = "Nostradamus";
			break;
		case 5: 
			team5 = "Nostradamus";
			break;
		}
		Buttons.CardsMenu ();
	}

	public void lancerRondelet() {
		switch (cptTours) {
		case 1: 
			team1 = "Nostradamus";
			break;
		case 2: 
			team2 = "Nostradamus";
			break;
		case 3: 
			team3 = "Nostradamus";
			break;
		case 4: 
			team4 = "Nostradamus";
			break;
		case 5: 
			team5 = "Nostradamus";
			break;
		}
		Buttons.CardsMenu ();
	}
}
