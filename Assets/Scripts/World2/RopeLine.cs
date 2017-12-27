using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeLine : MonoBehaviour {

	public GameObject stake;
	public Material lineMat;
	public Color lineColor;
	public float yOffset;
	public bool shouldDrawLine = false;
	// Use this for initialization
	void Start () {
		LineRenderer lineRenderer = gameObject.AddComponent <LineRenderer>() as LineRenderer;
		lineRenderer.material = lineMat;
		lineRenderer.SetWidth (0.1f, 0.1f);
		lineRenderer.SetVertexCount (2);
		lineRenderer.sortingOrder = 25;
		lineRenderer.sortingLayerName = "MiddleGround";
		lineRenderer.startColor = lineColor;
		lineRenderer.endColor = lineColor;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (shouldDrawLine) {
			LineRenderer lineRenderer = GetComponent<LineRenderer> ();
			float tmpY = transform.position.y;
			float stakeY = stake.transform.position.y;
			Vector3 tmpPosition = new Vector3 (transform.position.x, tmpY + yOffset, transform.position.z);
			Vector3 tmpStakePos = new Vector3 (stake.transform.position.x, stakeY + yOffset, stake.transform.position.z);
			lineRenderer.SetPosition (0, tmpPosition);
			lineRenderer.SetPosition (1, tmpStakePos);
		}
		
	}

	void UpdateStake(GameObject newStake){
		stake = newStake;
	
	}
}
