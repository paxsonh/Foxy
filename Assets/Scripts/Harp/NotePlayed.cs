using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePlayed : MonoBehaviour {

	public GameObject harp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			Vector2 origin = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);
			RaycastHit2D hit = Physics2D.Raycast (origin, Vector2.zero, 0f);
			if (hit) {
				if (hit.collider.gameObject.name == gameObject.name) {
					string lastPlayedItem = gameObject.GetComponent<GenericHit> ().hitAudio.name;
					harp.GetComponent<HarpBehavior> ().lastNotePlayed = lastPlayedItem;
					harp.SendMessage ("PlayedNote", lastPlayedItem);
				}
			}

		}
		
	}
}
