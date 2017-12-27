using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

	float distance = 10;
	public bool lockX;
	public bool shouldDrag = true;
	public bool dragging = false;

	public Vector3 originalPosition;

	void Start(){
		originalPosition = transform.position;
	}

	void OnMouseDown(){
		originalPosition = transform.position;
	
	}
	void OnMouseDrag(){
		if (shouldDrag) {
			dragging = true;
			if (lockX) {
				Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
				Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
				float objPosX = objPosition.x;
				float objPosY = originalPosition.y;
				float objPosZ = objPosition.z;
				transform.position = new Vector3 (objPosX, objPosY, objPosZ);
			} else {
				Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
				Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
				transform.position = objPosition;
			}

		}
		//transform.position = objPosition;

	}

	void OnMouseUp(){
		transform.position = originalPosition;
		dragging = false;
	}
}
