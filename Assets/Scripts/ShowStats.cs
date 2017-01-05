﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class ShowStats : MonoBehaviour {

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(gameObject.name + " Inertia: " + rigidBody.inertiaTensor);
		Debug.Log(gameObject.name + " COM: " + rigidBody.centerOfMass);
		Debug.Log(gameObject.name + " Ang. Vel.: " + rigidBody.angularVelocity);
	}
}
