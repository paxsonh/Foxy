using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stake : MonoBehaviour {

	public GameObject stakeWRope;
	public GameObject stakeToDrag;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "Stake") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			other.gameObject.SetActive (false);
		}

		if (other.gameObject.name == "Rope" && gameObject.GetComponent<SpriteRenderer>().enabled == true) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			stakeWRope.GetComponent<SpriteRenderer> ().enabled = true;
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			other.gameObject.SetActive (false);
			stakeToDrag.SetActive (true);
		}
	}
}
