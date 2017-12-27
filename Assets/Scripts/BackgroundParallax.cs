using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundParallax : MonoBehaviour {

    //public List<Transform> backgrounds;
	public Transform[] backgrounds;  			//array of all backgrounds
	public float parallaxScale;					// proportion of the cam movement to move the backgrounds by
	public float parallaxReductionFactor;		// How much less each successive layer should parallax
	public float smoothing;						// How smooth it should be
    public GameObject[] backgroundGameObjects;
	private Transform cam;
	private Vector3 previousCamPos;
    public static BackgroundParallax backgroundObject;
	private Transform player;



	// Use this for initialization
	void Awake(){

       /*backgroundGameObjects = GameObject.FindGameObjectsWithTag("Backgrounds");
        for (int j = 0; j < backgroundGameObjects.Length; j++)
        {
           backgrounds[j] = backgroundGameObjects[j].transform;
        } */
        cam = Camera.main.transform;

       /* if (backgroundObject == null)
        {

            DontDestroyOnLoad(gameObject);
            backgroundObject = this;
        }
        else if (backgroundObject != this)
        {
            Destroy(gameObject);

        } */

    }

	void Start(){
		previousCamPos = cam.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		float parallax = (previousCamPos.x - cam.position.x) * parallaxScale;


		//for each background
		for (int i = 0; i < backgrounds.Length; i++) {
		
			//set a target x pos which is current pos plus parallax multiplied by reduction
			float backgroundTargetPosX = backgrounds[i].position.x + parallax * (i * parallaxReductionFactor + 1);

			//Create target pos which is backgrounds cur pos but with target x pos
			Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

			// lerp backgroudn pos between itself and target position
			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
		
		
		}

		previousCamPos = cam.position;
	
	}
}
