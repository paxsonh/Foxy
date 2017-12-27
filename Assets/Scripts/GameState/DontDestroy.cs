using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

    public static DontDestroy dontDestroyPls;
	// Use this for initialization
	void Awake () {

        if (dontDestroyPls == null)
        {

            DontDestroyOnLoad(gameObject);
            dontDestroyPls = this;
        }
        else if (dontDestroyPls != this)
        {
            Destroy(gameObject);

        }

    }
	
}
