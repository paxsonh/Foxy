using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetClicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ResetAnimBool(){
		gameObject.GetComponent<Animator> ().SetBool ("Broken", false);
	}
}
