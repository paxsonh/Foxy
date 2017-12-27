using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("collided with:" + other.gameObject.name);
		if (other.gameObject.name == "Key") {
			gameObject.GetComponent<Animator> ().SetBool ("Open", true);
			player.GetComponent<FoxBehavior> ().SendMessage ("WalkToEnd");
			other.gameObject.SetActive(false);

		}
	}
}
