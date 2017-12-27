using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBehavior : MonoBehaviour {

	public GameObject keyObject;
	public GameObject itemHolder;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

			if (other.gameObject.name == "Flashlight") {
				keyObject.SetActive (true);
				other.gameObject.SetActive (false);
				itemHolder.SendMessage ("UpdateItemHolder", "Flashlight");
			}
	}

	void DropKey (){
		keyObject.SetActive (true);
	
	}
}
