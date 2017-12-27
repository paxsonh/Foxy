using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToLoad : MonoBehaviour {

	public string levelToLoadName;
	public bool shouldLoadLevel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (shouldLoadLevel) {
			SceneManager.LoadScene (levelToLoadName, LoadSceneMode.Single);
		}
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("collided with:" + other.gameObject.name);
		if (other.gameObject.tag == "Fox") {
			other.SendMessage ("LevelString", levelToLoadName);

		}
	}


}
