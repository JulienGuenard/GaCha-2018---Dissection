﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	public void MainGame() {
		SceneManager.LoadScene ("MainGame", LoadSceneMode.Single);
	}

	public void Credits() {
		SceneManager.LoadScene("Credits", LoadSceneMode.Single);
	}

	public void MainMenu() {
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}

	public void Commands() {
		SceneManager.LoadScene ("Commands", LoadSceneMode.Single);
	}

	public static void CardsMenu() {
		SceneManager.LoadScene ("CardMenu", LoadSceneMode.Single);
	}

	public void NamingMenu() {
		SceneManager.LoadScene ("MainGame", LoadSceneMode.Single);
	}

    public void CustomizationMenuPublic()
    {
        SceneManager.LoadScene("CustomizationMenu", LoadSceneMode.Single);
    }

	public static void CustomizationMenuButton() {
		SceneManager.LoadScene ("CustomizationMenu", LoadSceneMode.Single);
	}

	public static void TeamScore() {
		SceneManager.LoadScene("TeamScore", LoadSceneMode.Single);
	}

	public static void FinalScore() {
		SceneManager.LoadScene ("FinalScore", LoadSceneMode.Single);
	}

	public void Quit() {
		Application.Quit();
	}
}