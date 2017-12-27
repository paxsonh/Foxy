using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxStopper : MonoBehaviour {

	public bool OnElevator = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Fox") {
			OnElevator = true;
			other.gameObject.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
			other.gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		}

	}
}
