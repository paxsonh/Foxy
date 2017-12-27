using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

	public GameObject wheelObj;
	public GameObject player;
	public GameObject pointToWalkToTrans;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Fox");
	}
	
	// Update is called once per frame
	void Update () {

		if (pointToWalkToTrans.GetComponent<FoxStopper> ().OnElevator) {
			gameObject.GetComponent<Animator> ().SetBool ("FoxOnLift", true);
			wheelObj.GetComponent<Animator> ().SetBool ("WheelReverse", true);
		}
		
	}

	public void StopWheelObj(){
		wheelObj.GetComponent<Animator> ().SetBool ("FinishedMoving", true);
		player.GetComponent<FoxBehavior> ().pointToWalkTo = pointToWalkToTrans.transform;
		player.GetComponent<FoxBehavior> ().SendMessage ("WalkToPoint");

	}

	public void EndOfLift(){
		player.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Kinematic;
		player.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezePositionY;
		player.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		player.GetComponent<FoxBehavior> ().SendMessage ("WalkToEnd");
	}
}
