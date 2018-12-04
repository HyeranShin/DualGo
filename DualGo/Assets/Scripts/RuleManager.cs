using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleManager : MonoBehaviour {
    public GameObject rule1;
    public GameObject rule2;
    public GameObject rule3;

	// Use this for initialization
	void Start () {
        rule2.SetActive(false);
        rule3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            rule1.SetActive(false);
            rule2.SetActive(true);
            /*여기서 rule2 -> 3로 넘어가는 부분
            if (rule2.activeSelf == true && Input.GetMouseButton(0))
            {
                rule2.SetActive(false);
                rule3.SetActive(true);
            }
            */
        }        
        
	}
 
}
