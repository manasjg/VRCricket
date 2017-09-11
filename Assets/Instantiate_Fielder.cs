using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Fielder : MonoBehaviour {
    public GameObject Fielder;
    // Use this for initialization
    private void Start()
    {
        CreateFielders(Fielder);

    }
    public void CreateFielders(GameObject Fielder)
    {
        
        foreach (GameObject Position in GameObject.FindGameObjectsWithTag("Position"))
        {
            GameObject.Instantiate(Fielder, Position.transform.position, Quaternion.identity);
        }
        
    }
}
