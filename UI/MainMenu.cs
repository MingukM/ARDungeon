using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// When player start game it opens up the base camp
	public void PlayGame(){
		SceneManager.LoadScene ("Base");
	}

	// Allow player to quit game
	public void QuitGame() {
		Debug.Log ("QUIT");
		Application.Quit();
	}
}
