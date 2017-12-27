﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCanvasMode : MonoBehaviour {

	public float orthographicSize = 5;
	public float aspect = 1.33333f;
	void Start()
	{
		Camera.main.projectionMatrix = Matrix4x4.Ortho(
			-orthographicSize * aspect, orthographicSize * aspect,
			-orthographicSize, orthographicSize,
			gameObject.GetComponent<Camera>().nearClipPlane, gameObject.GetComponent<Camera>().farClipPlane);
	}
}
