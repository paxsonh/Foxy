using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

	public AudioClip hitAudio;
	public GameObject light;
	public GameObject pickUpPoint;
	public bool inSlot;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (inSlot) {
			pickUpPoint.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}

	void Hit(){

		gameObject.GetComponent<AudioSource> ().PlayOneShot (hitAudio);
		if (light.GetComponent<SpriteRenderer> ().enabled == true) {
			light.GetComponent<SpriteRenderer> ().enabled = false;
		} else {
			light.GetComponent<SpriteRenderer> ().enabled = true;
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Fox") {
			pickUpPoint.GetComponent<SpriteRenderer> ().enabled = true;
			pickUpPoint.GetComponent<BoxCollider2D> ().enabled = true;
		}

		/*if (other.gameObject.name == "Slot1") {
			Debug.Log ("SetPosition");
			gameObject.transform.position = other.gameObject.transform.position;
		}*/
	
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Fox") {

			pickUpPoint.GetComponent<SpriteRenderer> ().enabled = false;
			pickUpPoint.GetComponent<BoxCollider2D> ().enabled = false;
		}

	}
		
}
