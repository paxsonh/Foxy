using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlAwake : MonoBehaviour {
	public AudioClip hitAudio;
	public int hitCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Hit(){
		gameObject.GetComponent<Animator> ().SetBool ("Tapped", true);
		gameObject.GetComponent<AudioSource> ().PlayOneShot (hitAudio);
		hitCount++;

		if (hitCount >= 25) {
			gameObject.SendMessage ("DropKey");
		}
	
	}

	public void AnimationEnded(){
		gameObject.GetComponent<Animator> ().SetBool ("Tapped", false);
	
	}
}
