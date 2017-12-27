using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour {

	public GameObject fire1;
	public GameObject fire2;
	public bool onFire;
	// Use this for initialization
	void Start () {
		onFire = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "fire") {
			fire1.SetActive (true);
			fire2.SetActive (true);
			onFire = true;
		}

	}
}
