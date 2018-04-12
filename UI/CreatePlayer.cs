using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer{

	private Character newPlayer;

	void Start(){
		newPlayer = new Character ();
	}

	void Update(){

	}

	void OnGui(){
		if(GUILayout.Button("Create")){
			
		}
}
