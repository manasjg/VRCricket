using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class SelectFielder : MonoBehaviour {
    private float distance;
    private float mydistance;
    private float closestdist= 9999999.0F;
    private GameObject fielder;
    public GameObject target;
    private void Update()
    {
       if(this.gameObject.name== GetClosestFielder().name)
        {
            GetComponent<AICharacterControl>().SetTarget(target.transform);
        }

    }

    public GameObject GetClosestFielder()
    {
        mydistance = Vector3.Distance(target.transform.position, transform.position);

        foreach (GameObject Fielder in (GameObject.FindGameObjectsWithTag("Fielder")))
        {
            distance = Vector3.Distance(Fielder.transform.position, target.transform.position);

            if (distance < closestdist)
            {
                closestdist = distance;
                fielder = Fielder;
            }
        }
        
        return fielder;
        
    }
    
}
