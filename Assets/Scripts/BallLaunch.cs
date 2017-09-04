using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class BallLaunch : MonoBehaviour {
   
    public Vector3 launchSpeed;
    public float spin=0f;
    public int av;
    
    private SteamVR_TrackedController controller;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().maxAngularVelocity = av;
        GetComponent<Rigidbody>().AddTorque(transform.forward * spin);
        controller = GameObject.Find("Bat").GetComponent<SteamVR_TrackedController>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (controller.triggerPressed)
        {
            ballLaunch();
        }
        

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
        if (collision.gameObject.name != "Ground")
        {
          foreach(GameObject Fielder in (GameObject.FindGameObjectsWithTag("Fielder")))
            {
                Fielder.GetComponent<SelectFielder>().ballhit = true;
            }
        }

        
          
        
    }
   
    

  

}
