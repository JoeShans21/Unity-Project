using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 20;
    
    
	void Start () {
		rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rb.position.y < 10) {
			
		}
	}
}
