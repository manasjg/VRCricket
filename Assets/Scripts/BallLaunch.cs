using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour {
    public Vector3 launchSpeed;
    public float spin=0f;
    public int av;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().maxAngularVelocity = av;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddTorque(transform.forward*spin );
        

    }
    public void ballLaunch()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce(launchSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 0;
    }

}
