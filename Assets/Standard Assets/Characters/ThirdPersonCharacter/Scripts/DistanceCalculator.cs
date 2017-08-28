using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour {
    float distance;
    public Transform Target;
	// Use this for initialization
	void Start () {
        distance = Vector3.Distance(Target.transform.position, transform.position);
        Debug.Log(distance);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
