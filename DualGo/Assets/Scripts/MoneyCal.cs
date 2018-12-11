using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCal : MonoBehaviour {
    public InputField money;
    public Text result;

    public void onClick()
    {
        //result.text = 11111111+"";
        int a = Convert.ToInt32(money.text);
        result.text = (a * ResultScore.result) +"";
    }
}
