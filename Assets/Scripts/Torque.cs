using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour {

	public Vector3 torque = new Vector3(0, 0, 0);
	public float torqueTime = 0f;

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		if (this.torqueTime >= 0f) {
			rigidBody.AddTorque(this.torque);
			this.torqueTime -= Time.deltaTime;
		}
	}
}
