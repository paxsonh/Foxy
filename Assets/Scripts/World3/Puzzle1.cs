using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour {
	
	public GameObject fullBattery;
	public bool puzzleOn;
	public GameObject circleHolder;
	public GameObject puzzle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (puzzleOn && !puzzle.GetComponent<PuzzleMaster>().solved) {
			if (Input.GetMouseButtonDown (0)) {

				Vector2 origin = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);
				RaycastHit2D hit = Physics2D.Raycast (origin, Vector2.zero, 0f);
				if (hit.collider.gameObject.name == gameObject.name) {
					puzzle.SetActive (true);
				} 
			}
		}
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "batteryEmpty") {
			fullBattery.GetComponent<SpriteRenderer> ().enabled = true;
			other.gameObject.SetActive (false);
			puzzleOn = true;
		}
		if (other.gameObject.tag == "Fox" && puzzleOn  && !puzzle.GetComponent<PuzzleMaster>().solved) {
			circleHolder.GetComponent<SpriteRenderer> ().enabled = true;
		}

	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Fox" && puzzleOn) {
			circleHolder.GetComponent<SpriteRenderer> ().enabled = false;
			puzzle.SetActive (false);
		}
	}
}
