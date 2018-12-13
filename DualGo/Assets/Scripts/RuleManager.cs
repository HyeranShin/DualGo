using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleManager : MonoBehaviour
{
    public GameObject rule1;
    public GameObject rule2;
    public GameObject rule3;
    public GameObject modeChange;
    public GameObject text;
    private int rule_state;

    // Use this for initialization
    void Start()
    {
        rule_state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (rule_state)
            {
                case 0:
                    rule1.SetActive(false);
                    rule2.SetActive(true);
                    rule_state++;
                    break;
                case 1:
                    rule2.SetActive(false);
                    rule3.SetActive(true);
                    rule_state++;
                    break;
                case 2:
                    rule3.SetActive(false);
                    modeChange.SetActive(true);
                    text.SetActive(false);
                    break;
            }
        }

    }

}