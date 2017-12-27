using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public Transform rightPoint;
	public Transform leftPoint;
	public Camera mainCamera;
	private bool moveLeft = false;
	private bool moveRight = false;
	public Vector3 originalCamPos;

	public Vector3 clickPosition;
	public float speed = 1;
	// Use this for initialization
	void Start () {
		originalCamPos = gameObject.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetMouseButton(0)){
		clickPosition = Input.mousePosition;
		} */

		if (moveRight) {
			
			if (transform.position.x >= 15) {
				moveRight = false;
			}
			if (transform.position.x < 15) {
				transform.Translate (Vector3.right * speed);
			}
		}

		if (moveLeft) {
			
			if (transform.position.x <= -15) {
				moveLeft = false;
			}
			if (transform.position.x > -15) {
				transform.Translate (-Vector3.right * speed );
			}
		}
		
	}


	public void ResetCamera(){
		gameObject.transform.position = originalCamPos;
	}

	public void MoveRightTrue(){
		moveRight = true;
	
	}
	public void MoveRightFalse(){
		moveRight = false;

	}

	public void MoveLeftTrue(){
	
		moveLeft = true;
	}
	public void MoveLeftFalse(){

		moveLeft = false;
	}
}
