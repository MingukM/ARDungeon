using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class HealthBar : MonoBehaviour {

    Camera mainCamera;

    public Image healthBarImage;
    public Entity entity;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main;
        
	}
	
	// Update is called once per frame
	void Update () {

        // Sets the fill amount
        healthBarImage.fillAmount = (float)entity.health / 100;

        // Rotates the healthbar to face the camera
        transform.rotation = Quaternion.LookRotation(-mainCamera.transform.forward);

	}
}
