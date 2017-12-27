using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TmpLoad : MonoBehaviour {

	public string levelToLoadName;
	public GameObject foxyMan;
	public bool loadLevel = false;
	// Use this for initialization
	void Start () {
		if (levelToLoadName != null) {
			foxyMan = GameObject.FindGameObjectWithTag ("Fox");

		}
	}
	
	// Update is called once per frame
	void Update () {

		if (loadLevel) {
			
			foxyMan.SendMessage ("LevelString", levelToLoadName);
			Debug.Log ("Loading");
			foxyMan.SendMessage ("LoadLevel");
			loadLevel = false;
		}
		
	}
}
