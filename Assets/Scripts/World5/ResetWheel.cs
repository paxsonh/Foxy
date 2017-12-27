using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWheel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ResetAnimBool(){
		gameObject.GetComponent<Animator> ().SetBool ("WheelStuck", false);
		gameObject.GetComponent<Animator> ().SetBool ("WheelMove", false);
		gameObject.GetComponent<Animator> ().SetBool ("FinishedMoving", false);
	}
}
