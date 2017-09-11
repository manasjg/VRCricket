using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Reset_Pos : MonoBehaviour {
    public GameObject FielderObject;
    private Vector3 StartPos;
    private Vector3[] Positions= new Vector3[10];
    private int i = 0;
    // Use this for initialization
    void Start()
    {

        StartPos = transform.position;
        foreach (GameObject Fielder in (GameObject.FindGameObjectsWithTag("Fielder")))
        {
            Positions[i] = Fielder.transform.position;
           
            i++;
        }
    }

    public void ResetPosition()
    {
        transform.position = StartPos;
        GetComponent<Rigidbody>().velocity=Vector3.zero;
        GetComponent<Rigidbody>().useGravity = false;
        i = 0;
        var FielderPrefab = FielderObject;
        foreach (GameObject Fielder in (GameObject.FindGameObjectsWithTag("Fielder")))
        {
            Destroy(Fielder);
        }
        
        foreach (GameObject Position in GameObject.FindGameObjectsWithTag("Position"))
        {
            GameObject.Instantiate(FielderPrefab, Position.transform.position, Quaternion.identity);
        }

    }


}
