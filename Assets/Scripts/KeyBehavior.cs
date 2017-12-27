using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour {
	public bool inSlot;
	// Use this for initialization
	void Start () {
		if (inSlot) {
			gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "foreground3") {
			gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
			gameObject.transform.SetParent (null);
			gameObject.layer = 0;
			this.enabled = false;
		
		}
	
	}
}
