﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour {

	public static int cptTours = 1;

	public static string team1;
	public static string team2;
	public static string team3;
	public static string team4;
	public static string team5;



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
		Debug.Log ("gg batar");
	}

	public void lancerAndre() {
		switch (cptTours) {
		case 1: 
			team1 = "Vesale";
			break;
		case 2: 
			team2 = "Vesale";
			break;
		case 3: 
			team3 = "Vesale";
			break;
		case 4: 
			team4 = "Vesale";
			break;
		case 5: 
			team5 = "Vesale";
			break;
		}
		Buttons.CardsMenu ();
	}

	public void lancerRondelet() {
		switch (cptTours) {
		case 1: 
			team1 = "Rondelet";
			break;
		case 2: 
			team2 = "Rondelet";
			break;
		case 3: 
			team3 = "Rondelet";
			break;
		case 4: 
			team4 = "Rondelet";
			break;
		case 5: 
			team5 = "Rondelet";
			break;
		}
		Buttons.CardsMenu ();
	}
}
