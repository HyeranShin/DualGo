using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClick : MonoBehaviour {
    
    public void cardClickPi()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getPi();
        
    }
    public void cardClickTens()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getTens();
    }
    public void cardClickGodori()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getGodori();
    }
    public void cardClickDan()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getDan();
    }
    public void cardClickGwang()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getMine();
    }

  
}
