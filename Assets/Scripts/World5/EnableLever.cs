using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLever : MonoBehaviour {

	public bool leverActive = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "lever") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			other.gameObject.SetActive (false);
			leverActive = true;
		}
	}
}
