﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour {

	private Rigidbody rb;
	private Animation anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {

		// Moving the object using controller
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (x, 0, y);

		// Speed of the object
		rb.velocity = movement * 1/10f;

		// Rotation of the object
		if (x != 0 && y != 0) {
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, 
												Mathf.Atan2(x,y) * Mathf.Rad2Deg, 
												transform.eulerAngles.z);
		}

		if (x != 0 || y != 0) {
			anim.Play ("walk");
		} else {
			anim.Play ("idle");
		}
	}
}
