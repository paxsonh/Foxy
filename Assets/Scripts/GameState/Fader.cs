using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour {

	public GameObject fox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartLoad(){
		fox.SendMessage ("LoadLevel");

	}

	public void DisableFade(){
		gameObject.SetActive (false);
	}
}
