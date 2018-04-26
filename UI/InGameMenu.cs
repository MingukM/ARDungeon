using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour {

	// Allow palyer to go to dungeon by pressing a button on the screen
	public void GoToDungeon(){
		SceneManager.LoadScene ("Dungeon");
	}

	// Allow player to quit game
	public void QuitGame() {
		Debug.Log ("QUIT");
		Application.Quit();
	}

	// Allow player to go back to base from the dungeon
	public void GoToBase(){
		SceneManager.LoadScene ("Base");
	}
}
