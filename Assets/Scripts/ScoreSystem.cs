using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {
    private static int score = 0;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
  
        GetComponent<Text>().text = score.ToString();
      
    }
    
    public void IncrementScore()
    {
        score++;
       
    }
    public void InvokeScore()
    {
        InvokeRepeating("IncrementScore", 2, 3);
    }

    public void CancelScoreInvoke()
    {
        CancelInvoke();
    }
}
