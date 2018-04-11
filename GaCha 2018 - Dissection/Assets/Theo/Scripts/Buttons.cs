using System.Collections;
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
		SceneManager.LoadScene ("CardsMenu", LoadSceneMode.Single);
	}

	public void NamingMenu() {
		SceneManager.LoadScene ("NamingMenu", LoadSceneMode.Single);
	}

	public static void CustomizationMenu() {
		SceneManager.LoadScene ("CustomizationMenu", LoadSceneMode.Single);
	}

	public void Quit() {
		Application.Quit();
	}
}