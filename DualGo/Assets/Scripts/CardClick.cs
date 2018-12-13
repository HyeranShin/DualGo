using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClick : MonoBehaviour {
    public GameObject button;
    
    public void cardClickPi()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getPi();
        button.SetActive(false);

    }
    public void cardClickTens()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getTens();
        button.SetActive(false);
    }
    public void cardClickGodori()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getGodori();
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getTens();
        button.SetActive(false);
    }
    public void cardClickDan()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getDan();
        button.SetActive(false);
    }
    public void cardClickGwang()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getMine();
        button.SetActive(false);
    }
    public void cardClickSSang()
    {
        ScoreManager isDouble = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        isDouble.double_pi = true;
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getPi();
        button.SetActive(false);
    }



}
