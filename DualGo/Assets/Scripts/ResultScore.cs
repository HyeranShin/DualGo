using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {

    public static int result = 12;
    public Text text_score;

    // Use this for initialization
    void Start () {
        text_score.text = result+"점";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
