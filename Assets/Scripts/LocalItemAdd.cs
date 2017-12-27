using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalItemAdd : MonoBehaviour {

	public GameObject itemHolder;
	public List<GameObject> itemsToAdd;
	public string objectiveText;
	public bool shouldReplayOnStart = true;
	// Use this for initialization
	void Start () {
		itemHolder = GameObject.Find ("Slot1");

		itemHolder.SendMessage ("ClearItemHolder");
		itemHolder.SendMessage ("ResetActive");
		itemHolder.SendMessage ("AddToList", itemsToAdd);
		Camera.main.SendMessage ("UpdateCurrentObject", objectiveText);
		if (shouldReplayOnStart) {
			Camera.main.SendMessage ("ReplayHint");
		}
	}

}
