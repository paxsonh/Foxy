using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour {

	public GameObject MainCamera;
	public float currentZoom;
	public float whatToZoomTo;
	public float timeToZoom;
	public bool inTrigger;
	public bool hasAnimated;
	public float timeHolder;
	public float speed;

	// Use this for initialization
	void Start () {

		MainCamera = GameObject.Find ("Main Camera");
		//timeHolder = timeToZoom;
		hasAnimated = false;
		currentZoom = MainCamera.GetComponent<Camera>().orthographicSize;
		
	}
	
	// Update is called once per frame
	void Update () {

		//currentZoom = MainCamera.orthographicSize;

		if (inTrigger && !hasAnimated) {
			timeToZoom += Time.deltaTime * speed;
			MainCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp (currentZoom, whatToZoomTo, timeToZoom);
			if(MainCamera.GetComponent<Camera>().orthographicSize >= whatToZoomTo){
				hasAnimated = true;
				timeHolder = timeToZoom;

			}
		}

		if (!inTrigger && !hasAnimated) {
			timeHolder -= Time.deltaTime * speed;
			MainCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp (currentZoom, whatToZoomTo, timeHolder);
			if(MainCamera.GetComponent<Camera>().orthographicSize <= currentZoom){
				hasAnimated = true;
				timeToZoom = 0;
			}
		}
		
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Fox") {
			hasAnimated = false;
			inTrigger = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Fox") {
			timeHolder = timeToZoom;
			inTrigger = false;
			hasAnimated = false;
		}
	}
}
