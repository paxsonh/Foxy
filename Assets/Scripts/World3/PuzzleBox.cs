using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBox : MonoBehaviour {

	public bool empty;
	public int numOfBoxesCovered;
	public bool green;
	public bool blue;

	public Sprite[] boxType;

	public string currentType;
	public string currentSprite;

	public bool mouseDownButton;

	public bool slot1;
	public bool slot2;
	public bool slot3;
	public string expectedColor;
	public GameObject puzzleMaster;

	// Use this for initialization
	void Start () {
		numOfBoxesCovered = 1;
		if (empty) {
			SetEmpty ();
		}
		if (green) {
			SetGreen ();
		}
		if (blue) {
			SetBlue ();
		}


	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			
			Vector2 origin = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
			RaycastHit2D hit = Physics2D.Raycast (origin, Vector2.zero, 0f);
			if (hit.collider.name == gameObject.name) {
				mouseDownButton = true;
			}
		}
		if (Input.GetMouseButtonUp (0)) {
			mouseDownButton = false;
			numOfBoxesCovered = 1;
		}
		if (expectedColor != null && gameObject.GetComponent<SpriteRenderer> ().sprite != null) {
			if (gameObject.GetComponent<SpriteRenderer> ().sprite.name == expectedColor) {
				if (slot1) {
					puzzleMaster.GetComponent<PuzzleMaster> ().slot1Correct = true;
				}
				if (slot2) {
					puzzleMaster.GetComponent<PuzzleMaster> ().slot2Correct = true;
				}
				if (slot3) {
					puzzleMaster.GetComponent<PuzzleMaster> ().slot3correct = true;
				}
			}
		}
		else {
			if (slot1) {
				puzzleMaster.GetComponent<PuzzleMaster> ().slot1Correct = false;
			}
			if (slot2) {
				puzzleMaster.GetComponent<PuzzleMaster> ().slot2Correct = false;
			}
			if (slot3) {
				puzzleMaster.GetComponent<PuzzleMaster> ().slot3correct = false;
			}

		}

		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Box" && other.gameObject.GetComponent<SpriteRenderer> ().sprite != null) {
			numOfBoxesCovered++;
		}

		if (other.gameObject.GetComponent<SpriteRenderer> ().sprite == null && mouseDownButton) {
			if (numOfBoxesCovered >= 1 && numOfBoxesCovered < 3) {
				if (gameObject.GetComponent<SpriteRenderer> ().sprite.name == "greenCircle") {
					other.gameObject.GetComponent<PuzzleBox> ().SetGreen ();

				} else {
					other.gameObject.GetComponent<PuzzleBox> ().SetBlue ();
				}
				SetEmpty ();	
			}
			
		}
	}


	public void SetEmpty(){
		
	
				gameObject.GetComponent<SpriteRenderer> ().sprite = null;
				gameObject.GetComponent<MouseDrag> ().enabled = false;


	}

	public void SetBlue(){
		
		for (int i = 0; i < boxType.Length; i++) {
			if (boxType [i].name == "bluediamond") {
				gameObject.GetComponent<SpriteRenderer> ().sprite = boxType [i];
			}
		}

	
	}

	public void SetGreen(){
		
		for (int i = 0; i < boxType.Length; i++) {
			if (boxType [i].name == "greenCircle") {
				gameObject.GetComponent<SpriteRenderer> ().sprite = boxType [i];

			}
		}
	
	}
}
