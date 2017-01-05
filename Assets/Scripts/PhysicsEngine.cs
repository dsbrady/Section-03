using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEngine : MonoBehaviour {

	public Vector3 initialAngularVelocity = new Vector3(4f, 0, 0);

	private Rigidbody rigidBody;

	void OnEnable () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.angularVelocity = this.initialAngularVelocity;
	}
}
