using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    // Use this for initialization
    void Start () 
    {
    }
    
    // LateUpdate is called after Update each frame
    void Update () 
    {
		transform.position = new Vector3 (transform.position.x, 1, transform.position.z);
    }
}