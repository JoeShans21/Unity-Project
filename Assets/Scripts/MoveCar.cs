using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class MoveCar: MonoBehaviour
 {
     public float speed = 10;
     public Rigidbody rb;
     
     void Start(){
        rb = gameObject.GetComponent<Rigidbody>();
     }
     
     void FixedUpdate(){
        if (Input.GetKey(KeyCode.W)){
			rb.velocity = new Vector3(0, 0, 10);
        }
     }
 }