using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Fox");
		player.GetComponent<FoxBehavior> ().endPoint = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
