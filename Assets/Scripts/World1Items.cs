using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class World1Items : MonoBehaviour {

	public string findItemText;
	public List<GameObject> findItemObject;
	public int currentObjective;
	public Text hintText;
	public GameObject currentObjectToFind;
	private bool hasPlayedAnim = false;

	// Use this for initialization
	void Start () {

	

	}
	
	// Update is called once per frame
	void Update () {

	}


	void UpdateCurrentObject(string NewObjective){
		findItemText = NewObjective;
		hintText.text = findItemText;
		
	}

	public void ReplayHint(){
	
		hintText.GetComponent<Animator> ().Play ("TextAnimation", -1, 0.12f);
	}

}
