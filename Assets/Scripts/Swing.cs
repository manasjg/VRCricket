using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour {
    public float batspeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //GetComponent<Rigidbody>().AddTorque(transform.right * batspeed);
        //Debug.Log(GetComponent<Rigidbody>().angularVelocity);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.contacts[0].point);
    }
}
