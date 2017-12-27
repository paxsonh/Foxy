using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrig : MonoBehaviour {

	private bool canSetPoint = false;
	public GameObject circleHolder;
	public GameObject leverObj;
	public GameObject wheelObj;
	public GameObject brakeObj;
	public GameObject liftObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponentInChildren<EnableLever> ().leverActive) {
			canSetPoint = true;
		}
		if (circleHolder.GetComponent<SpriteRenderer> ().enabled) {
			if (Input.GetMouseButtonDown (0)) {

				Vector2 origin = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);
				RaycastHit2D hit = Physics2D.Raycast (origin, Vector2.zero, 0f);
				if (hit.collider.gameObject.name == "SetLever") {
					if (brakeObj.activeSelf) {
						leverObj.GetComponent<Animator> ().SetBool ("PullLever", true);
						wheelObj.GetComponent<Animator> ().SetBool ("WheelStuck", true);
						brakeObj.GetComponent<Animator> ().SetBool ("Broken", true);

					} else {
						leverObj.GetComponent<Animator> ().SetBool ("PullLever", true);
						wheelObj.GetComponent<Animator> ().SetBool ("WheelMove", true);
						liftObj.GetComponent<Animator> ().SetBool ("BridgeLeverSuccess", true);
					}
				} 
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Fox" && canSetPoint) {
			circleHolder.GetComponent<SpriteRenderer> ().enabled = true;
		}

	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Fox" && canSetPoint) {
			circleHolder.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}
