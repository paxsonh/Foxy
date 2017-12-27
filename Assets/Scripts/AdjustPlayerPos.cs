using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustPlayerPos : MonoBehaviour {

	public float yOffset;
	public GameObject foxPlayer;
	// Use this for initialization
	void Start () {
		foxPlayer = GameObject.FindGameObjectWithTag ("Fox");
		foxPlayer.GetComponent<FoxBehavior> ().SendMessage ("SetPlayerPosition", yOffset);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
