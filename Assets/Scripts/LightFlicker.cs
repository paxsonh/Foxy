using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {

	public float minIntensity = 0.25f;
	public float maxIntensity = 0.5f;

	float random;
	// Use this for initialization
	void Start () {
		random = Random.Range(0.0f, 65535.0f);
	}
	
	// Update is called once per frame
	void Update () {
		float noise = Mathf.PerlinNoise(random, Time.time);
		gameObject.GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
	}
}
