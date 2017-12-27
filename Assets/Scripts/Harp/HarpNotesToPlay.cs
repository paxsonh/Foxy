using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpNotesToPlay : MonoBehaviour {

	public AudioClip[] notesToPlay;
	public int numOfNotes = 0;
	public GameObject harp;
	public bool hitHarp = false;
	public float timeForNote;
	private float timeForNoteHolder;
	// Use this for initialization
	void Start () {
		harp.GetComponent<HarpBehavior> ().notesToPlay = notesToPlay;
		timeForNoteHolder = timeForNote;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			Vector2 origin = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);
			RaycastHit2D hit = Physics2D.Raycast (origin, Vector2.zero, 0f);
			if (hit) {
				if (hit.collider.gameObject.name == gameObject.name) {
					hitHarp = true;
				}
			}

		}
		if (hitHarp) {
			timeForNote -= Time.deltaTime;
			if (timeForNote < 0) {
				gameObject.GetComponent<AudioSource> ().clip = notesToPlay [numOfNotes];
				gameObject.GetComponent<AudioSource> ().Play ();
				numOfNotes++;
				timeForNote = timeForNoteHolder;
			}

			/*if (!gameObject.GetComponent<AudioSource> ().isPlaying && numOfNotes != notesToPlay.Length) {
				gameObject.GetComponent<AudioSource> ().clip = notesToPlay [numOfNotes];
				gameObject.GetComponent<AudioSource> ().Play ();
				numOfNotes++;
			} */

			if (numOfNotes == notesToPlay.Length) {
				numOfNotes = 0;
				hitHarp = false;
			}
		}
		
	}

	IEnumerator PlayNote(){
		gameObject.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (gameObject.GetComponent<AudioSource> ().clip.length);
	
	}
}
