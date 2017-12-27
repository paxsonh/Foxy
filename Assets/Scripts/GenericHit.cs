using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericHit : MonoBehaviour {

	public AudioClip hitAudio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Hit(){
		
		gameObject.GetComponent<AudioSource> ().PlayOneShot (hitAudio);

	}
}
