﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (transform, this);
	}




}
