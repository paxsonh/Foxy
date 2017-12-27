using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrake : MonoBehaviour {

	public GameObject brakeObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "hammer") {
			brakeObj.SetActive (false);
			other.gameObject.SetActive (false);

		}
	}
}
