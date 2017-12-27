using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour {

	public List<GameObject> itemsToHold;
	public List<GameObject> localItems;
	public Transform slot1;
	public Transform slot2;
	public bool isLocalItem = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log (other.gameObject.name);

		for(int j = 0; j < localItems.Count; j ++){
			if (other.gameObject.name == localItems [j].gameObject.name) {
				isLocalItem = true;
			}
		}
		for (int i = 0; i < itemsToHold.Count; i++) {
			if (other.gameObject.name == itemsToHold [i].gameObject.name && isLocalItem) {
				itemsToHold [i].SetActive (true);
				itemsToHold [i].GetComponent<BoxCollider2D> ().enabled = true;
				UpdateItemHolder (other.gameObject.name);
				Destroy (other.gameObject);
				isLocalItem = false;
			}
		
		}

	}

	void UpdateItemHolder(string ItemToRemove){

		for(int j = 0; j < localItems.Count; j ++){
			if (ItemToRemove == localItems [j].gameObject.name) {
				localItems.RemoveAt (j);
			}
		}
		/*for (int i = 0; i < itemsToHold.Count; i++) {

			if (ItemToRemove == itemsToHold[i].name) {
				itemsToHold.RemoveAt (i);
			}

		}*/
	
	}

	void ClearItemHolder(){
		localItems.Clear ();
	}

	void ResetActive(){
		for (int i = 0; i < itemsToHold.Count; i++) {
			itemsToHold [i].SetActive (false);
		}
	}

	void AddToList(List<GameObject> ItemsToAdd){
		for (int i = 0; i < ItemsToAdd.Count; i++) {
			localItems.Add (ItemsToAdd [i]);
		}
	}
}
