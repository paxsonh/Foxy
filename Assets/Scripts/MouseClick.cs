using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour {

	public Text textToUpdate;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
		
			Vector2 origin = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
			RaycastHit2D hit = Physics2D.Raycast (origin, Vector2.zero, 0f);
			if (hit) {
				textToUpdate.text = hit.collider.name;
				hit.collider.gameObject.SendMessage ("Hit");
				//if (hit.collider.name == gameObject.GetComponent<World1Items> ().currentObjectToFind.name) {
					//gameObject.SendMessage ("UpdateCurrentObject");
				//}
			}
		}
		
	}




}
