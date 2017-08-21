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
        GetComponent<Rigidbody>().AddTorque(transform.forward * spin);
    }
	
	// Update is called once per frame
	void Update () {
        
        

    }
    public void ballLaunch()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce(launchSpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 0;
        GetComponent<Rigidbody>().AddTorque(-transform.forward * spin);
        Debug.Log(collision.gameObject.name);
    }

}
