using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoxBehavior : MonoBehaviour {

	public float randomNum;
	public float randomNum2;
	public bool FoxIsRunning = false;
	public Transform endPoint;
	public bool shouldWalkToEnd = false;
	public float speed;

	public GameObject leftButton;
	public GameObject rightButton;

	public Vector3 OriginalFoxTransform;

	public string levelToLoadString;
	public GameObject fade;

	public bool walkingToPoint = false;
	public Transform pointToWalkTo;
	// Use this for initialization
	void Start () {
		randomNum = Random.Range(5.0f, 15.0f);
		randomNum2 = Random.Range(4.0f, 10.0f);
		OriginalFoxTransform = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!FoxIsRunning) {
			if (!gameObject.GetComponent<Animator> ().GetBool ("FoxSit")) {
				randomNum -= Time.deltaTime;
				if (randomNum < 0) {
					randomNum = Random.Range (0.0f, 5.0f);
					gameObject.GetComponent<Animator> ().SetBool ("FoxIdle", false);
					gameObject.GetComponent<Animator> ().SetBool ("FoxSit", true);

		
				}
			} else {
				randomNum2 -= Time.deltaTime;
				if (randomNum2 < 0) {
					randomNum2 = Random.Range (0.0f, 5.0f);
					gameObject.GetComponent<Animator> ().SetBool ("FoxSit", false);
					gameObject.GetComponent<Animator> ().SetBool ("FoxIdle", true);
				}
		
		
			}

		}

		if (shouldWalkToEnd) {
			float step = speed * Time.deltaTime;
			transform.Translate (Vector3.left * step);
			if (transform.position.x > endPoint.position.x) {
				Debug.Log ("At End");
				fade.SetActive (true);
			}
		
		}

		if (walkingToPoint) {
			float step = speed * Time.deltaTime;
			transform.Translate (Vector3.left * step);
			if (transform.position.x > pointToWalkTo.position.x) {
				Debug.Log ("At Point");
				FoxRunRelease ();
				walkingToPoint = false;
			}

		}



	}

	public void WalkToEnd(){
		shouldWalkToEnd = true;
		FlipRight ();
		FoxRun ();
		leftButton.SetActive (false);
		rightButton.SetActive (false);

	
	}

	public void WalkToPoint(){
		walkingToPoint = true;
		FlipRight ();
		FoxRun ();
		leftButton.SetActive (false);
		rightButton.SetActive (false);


	}

	void LevelString(string levelToLoad){
	
		levelToLoadString = levelToLoad;
	}

	public void LoadLevel(){
		
		shouldWalkToEnd = false;
		FoxRunRelease ();
		SceneManager.LoadScene (levelToLoadString, LoadSceneMode.Single);
		gameObject.GetComponentInParent<MoveCamera> ().SendMessage ("ResetCamera");
		leftButton.SetActive (true);
		rightButton.SetActive (true);

		//fade.SetActive (false);
		fade.GetComponent<Animator> ().SetBool ("FadeOut", true);
	
	}



	public void ResetLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		gameObject.GetComponentInParent<MoveCamera> ().SendMessage ("ResetCamera");
	}

	public void SetPlayerPosition (float yOffset){
	
		Vector3 tempPlayerPos = new Vector3(OriginalFoxTransform.x, OriginalFoxTransform.y + yOffset, OriginalFoxTransform.z);
		gameObject.transform.position = tempPlayerPos;
	}


	public void FoxRun(){
		FoxIsRunning = true;
		gameObject.GetComponent<Animator> ().SetBool ("FoxSit", false);
		gameObject.GetComponent<Animator> ().SetBool ("FoxIdle", false);
		gameObject.GetComponent<Animator> ().SetBool ("FoxRun", true);
	}

	public void FoxRunRelease(){
		FoxIsRunning = false;
		gameObject.GetComponent<Animator> ().SetBool ("FoxIdle", true);
		gameObject.GetComponent<Animator> ().SetBool ("FoxRun", false);
	}


	public void FlipRight(){

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.z *= -1;
		transform.localScale = theScale;

		Quaternion theRotation = transform.rotation;
		theRotation.y += 180.0f;

		transform.rotation = theRotation;
	
	}

	public void FlipLeft(){

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.z *= -1;
		transform.localScale = theScale;

		Quaternion theRotation = transform.rotation;
		theRotation.y = 0.0f;
		//theRotation.z = startZRotation;
		transform.rotation = theRotation;

	}

}
