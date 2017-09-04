using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class SelectFielder : MonoBehaviour {
    private float distance;
    private float mydistance;
    private float closestdist= 9999999.0F;
    private GameObject fielder;
    private GameObject target;
    public bool ballhit;
    private void Start()
    {
        target = GameObject.Find("Ball1");
    }
    private void Update()
    {
        if (ballhit)
        {
            StartCoroutine(GetClosestFielder());
        }
    }

    public IEnumerator GetClosestFielder()
    {
        yield return new WaitForSeconds(0.5f);

        foreach (GameObject Fielder in (GameObject.FindGameObjectsWithTag("Fielder")))
        {
            distance = Vector3.Distance(Fielder.transform.position, target.transform.position);

            if (distance < closestdist)
            {
                closestdist = distance;
                fielder = Fielder;
            }
        }

        if (this.gameObject.name == fielder.gameObject.name)
        {
            GetComponent<AICharacterControl>().SetTarget(target.transform);
        }

    }
    
}
