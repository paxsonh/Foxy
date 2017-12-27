using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealHammer : MonoBehaviour {

	public GameObject rockObj;
	public GameObject rockObjDragPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.GetComponent<HammerFind> ().hammerFound) {
			gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 15;
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			gameObject.GetComponent<MouseDrag> ().shouldDrag = true;
			rockObj.GetComponent<MouseDrag> ().shouldDrag = false;
			rockObj.GetComponent<BoxCollider2D> ().enabled = false;
			rockObjDragPoint.SetActive (false);
		}
		
	}
}
