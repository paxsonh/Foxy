using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnThicket : MonoBehaviour {

	public GameObject thicketFire;
	public GameObject player;
	public bool doneAnimating;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Fox");
		
	}
	
	// Update is called once per frame
	void Update () {

		if (doneAnimating) {
			player.GetComponent<FoxBehavior> ().SendMessage ("WalkToEnd");
			doneAnimating = false;
		}

		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "log") {
			if (other.gameObject.GetComponent<OnFire> ().onFire) {
				thicketFire.SetActive (true);
				gameObject.GetComponent<Animator> ().SetBool ("OnFire", true);
				other.gameObject.SetActive(false);
			}


		}

	}
}
