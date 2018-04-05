using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler {

	private Image bgImg;
	private Image joystickImg;
	private Vector3 inputVector;

	private void start(){
		bgImg = GetComponent<Image> ();
		joystickImg = transform.GetChild(0).GetComponent<Image> ();
	}

	public virtual void OnDrag(PointerEventData ped){
		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (bgImg.rectTransform
																	, ped.position
																	, ped.pressEventCamera
																	, out pos)) {
			pos.x = 
		}
	}

	public virtual void OnPointerDown(PointerEventData ped){
		OnDrag (ped);
	}

	public virtual void OnPointerUp(PointerEventData ped){

	}
}
