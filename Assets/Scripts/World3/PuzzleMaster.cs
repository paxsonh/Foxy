using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMaster : MonoBehaviour {

	public bool slot1Correct;
	public bool slot2Correct;
	public bool slot3correct;
	public GameObject puzzleFinish;
	public bool solved = false;
	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Fox");
	}
	
	// Update is called once per frame
	void Update () {

		if (slot1Correct && slot2Correct && slot3correct) {
			Debug.Log ("You solved it");
			solved = true;
			puzzleFinish.GetComponent<SpriteRenderer> ().enabled = true;
			gameObject.SetActive (false);
			player.GetComponent<FoxBehavior> ().SendMessage ("WalkToEnd");

		}
		
	}
		
}
