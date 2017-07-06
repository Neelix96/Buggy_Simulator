﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	public float speed = 10.0f;
    public float roationspeed = 10.0f;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * roationspeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		transform.Translate (0, 0, translation);
        transform.Rotate (0, rotation, 0);

		if (Input.GetKeyDown ("escape"))
			Cursor.lockState = CursorLockMode.None;
	}
}
