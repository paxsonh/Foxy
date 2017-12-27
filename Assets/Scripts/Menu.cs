using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public GameObject menuBack;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleMenu(){
		if (menuBack.activeSelf) {
			menuBack.SetActive (false);
			Camera.main.GetComponent<MouseClick> ().enabled = true;
		
		} else {
			menuBack.SetActive (true);
			Camera.main.GetComponent<MouseClick> ().enabled = false;
		}

	}
}
