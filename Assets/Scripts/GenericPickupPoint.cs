using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPickupPoint : MonoBehaviour {


	public GameObject objectToGrab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Fox") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			objectToGrab.GetComponent<BoxCollider2D> ().enabled = false;
			objectToGrab.GetComponent<BoxCollider2D> ().enabled = true;
		}

	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Fox") {

			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			if (!objectToGrab.GetComponent<MouseDrag> ().dragging) {
				objectToGrab.GetComponent<BoxCollider2D> ().enabled = false;
			}


		}

	}
}
