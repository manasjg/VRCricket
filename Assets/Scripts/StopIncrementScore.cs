using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopIncrementScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fielder")
        {
            
            GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreSystem>().CancelScoreInvoke();
            GetComponent<Reset_Pos>().ResetPosition();
            
        }
    }
}
