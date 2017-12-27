using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stake2 : MonoBehaviour {

	public GameObject ropeLine;
	public GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Fox");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log ("RopeHit" + other.gameObject.name);
		if (other.gameObject.name == "stakewithrope3") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			other.gameObject.SetActive (false);
			ropeLine.GetComponent<RopeLine> ().SendMessage ("UpdateStake", gameObject);
			ropeLine.GetComponent<RopeLine> ().shouldDrawLine = true;
			player.GetComponent<FoxBehavior> ().SendMessage ("WalkToEnd");
		}

	}
}
