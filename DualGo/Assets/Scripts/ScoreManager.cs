using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text text_score;
    public Text text_multiple;
    public GameObject ob_X;
    public GameObject ob_multiple;
    public GameObject ob_gobtn;
    public GameObject ob_stopbtn;
    public GameObject ob_goorstop;
    public Button btn_go;
    public Button btn_stop;

    private int score;
    private int multiple;
    private int go_num;
    private bool state_7;
    private int mine;   // 광
    private bool spectroscopy;  // 비광
    private int dan;   // 띠
    private int hongdan;
    private int chungdan; 
    private int chodan;

    // ********점수 얻는 함수마다 if (state_7) goStop(); 넣어주세용

    // Use this for initialization
    void Start () {
        ///////////////////혜란//////////////////////
        score = 0;
        multiple = 1;
        text_score.text = score+"";
        text_multiple.text = 1 + "";
        ob_X.SetActive(false);
        ob_multiple.SetActive(false);
        ob_goorstop.SetActive(false);
        ob_gobtn.SetActive(false);
        ob_stopbtn.SetActive(false);

        state_7 = false;
        ///////////////////예원//////////////////////

    }

    // Update is called once per frame
    void Update ()
    {
        ///////////////////혜란//////////////////////
        checkScore7();

        ///////////////////예원//////////////////////

    }

    ///////////////////혜란//////////////////////
    /*
1. 광
> 3장 3점(단, 비광 포함 시 2점) ‘삼광’
> 4장 점 ‘사광’, 5장 5점 ‘오광’
      */
      void getMine()
    {

    }
    /*
4. 띠
> 5장 1점
> ‘청단’ 3장 3점
> ‘홍단’ 3장 3점
> ‘초단’ 3장 3점
     */
     void getBand()
    {

    }
    /*
6. 고/스톱
> 7점부터 점수 얻을 때 마다 고/ 스톱 가능
> 1고, 2고는 1점씩 추가
> 3고는 2배
> 4고는 4배, 5고는 8배... 2배씩 커진다.
      */
    void checkScore7()
    {
        if (score * multiple >= 7)
        {
            if (!state_7) state_7 = true;
        }
    }
    void goStop()
    {
        // 고 or Stop
        ob_goorstop.SetActive(true);
        ob_gobtn.SetActive(true);
        ob_stopbtn.SetActive(true);
        btn_go.onClick.AddListener(goScore);
        btn_stop.onClick.AddListener(goResultScene);
    }

   void goScore()
    {
        switch(go_num)
        {
            case 0: // 1고
                go_num++;
                score++;
                break;
            case 1: // 2고
                go_num++;
                score++;
                break;
            case 2: // 3고
                go_num++;
                multiple = multiple * 2;
                break;
            case 3: // 4고
                go_num++;
                multiple = multiple * 2;
                break;
            case 4: // 5고
                go_num++;
                multiple = multiple * 2;
                break;
            case 5: // 6고
                go_num++;
                multiple = multiple * 2;
                break;
            case 6: // 7고
                go_num++;
                multiple = multiple * 2;
                break;
            case 7: // 8고
                go_num++;
                multiple = multiple * 2;
                break;
            case 8: // 9고
                go_num++;
                multiple = multiple * 2;
                break;
            case 9: // 10고
                go_num++;
                multiple = multiple * 2;
                break;
        }
    }

    void goResultScene()
    {
        Application.LoadLevel("ResultScene");
    }

    ///////////////////예원//////////////////////

}
