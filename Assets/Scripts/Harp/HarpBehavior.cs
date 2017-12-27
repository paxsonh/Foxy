using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpBehavior : MonoBehaviour {

	public string lastNotePlayed;
	public int numOfNotesToPlay = 0;
	public AudioClip[] notesToPlay;
	public string audioNote;
	public bool solved = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!solved) {
			audioNote = notesToPlay [numOfNotesToPlay].name;
		}
		
	}

	void PlayedNote(string lastNotePlayed){
		if (!solved) {
			audioNote = notesToPlay [numOfNotesToPlay].name;
			if (lastNotePlayed == audioNote) {
				Debug.Log ("same");
				numOfNotesToPlay++;

			}


			if (lastNotePlayed != audioNote) {
				Debug.Log ("Wrong");
				numOfNotesToPlay = 0;
			}

			if (numOfNotesToPlay == notesToPlay.Length) {
				Debug.Log ("Solved");
				solved = true;

			}
		}

	
	}
}
