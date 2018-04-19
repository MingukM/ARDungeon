using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour {

	// Allow palyer to go to dungeon by pressing a button on the screen
	public void GoToDungeon(){
		SceneManager.LoadScene ("Dungeon");
	}
}
