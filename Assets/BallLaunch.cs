using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour {
    public Vector3 launchSpeed;
    public float spin=0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        GetComponent<Rigidbody>().AddTorque(transform.forward*spin );

    }
    public void ballLaunch()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce(launchSpeed);
    }
 
}
