using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerFind : MonoBehaviour {

	public bool hammerFound = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.gameObject.name);
	}


	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "rock") {
			hammerFound = true;
		}
	}
}
