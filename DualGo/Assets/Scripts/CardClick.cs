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
    public void cardClickHongdan()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getHongdan();
        button.SetActive(false);
    }
    public void cardClickChungdan()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getChungdan();
        button.SetActive(false);
    }
    public void cardClickChodan()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getChodan();
        button.SetActive(false);
    }
    public void cardClickGwang()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getMine();
        button.SetActive(false);
    }
    public void cardClickSSang()
    {//여기서 바꾼 doubl_pi 값이 스코어 매니저에 적용 되게,,,
        ScoreManager.double_pi = true;
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().getPi();
        button.SetActive(false);
        //Debug.Log(ScoreManager.double_pi);
    }
    public void mungUI_Click()
    {
        ScoreManager isMung = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        isMung.mung_UI.SetActive(false);
    }
    public void godoriUI_Click()
    {
        ScoreManager isGodori = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        isGodori.godori_UI.SetActive(false);
    }



}
