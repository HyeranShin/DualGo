using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text text_score;
    public Text text_multiple;
    public GameObject ob_X;
    public GameObject ob_multiple;
    public GameObject ob_gobtn;
    public GameObject ob_stopbtn;
    public GameObject ob_goorstop;
    public Button btn_go;
    public Button btn_stop;
    public GameObject mung_UI;
    public GameObject godori_UI;
    public GameObject mine3_UI;
    public GameObject mine4_UI;
    public GameObject mine5_UI;
    public GameObject dan5_UI;
    public GameObject chodan_UI;
    public GameObject chungdan_UI;
    public GameObject hongdan_UI;
    public GameObject go1_UI;
    public GameObject go2_UI;
    public GameObject go3_UI;
    public GameObject go4_UI;
    public GameObject go5_UI;   
    public GameObject go6_UI;
    public GameObject go7_UI;
    public GameObject go8_UI;
    public GameObject pi_UI;

    static int total_score;
    private int temp;
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
    private int godori;
    private int tens; //열끗
    private int pi; //피
    public static bool double_pi; //쌍피
    public bool mung_dda; //멍따 체크 

    private int go1_state;
    private int go2_state;
    private int go3_state;
    private int go4_state;
    private int go5_state;
    private int go6_state;
    private int go7_state;
    private int go8_state;


    // ********점수 얻는 함수마다 if (state_7) goStop(); 넣어주세용
    // Use this for initialization
    void Start()
    {
        ///////////////////혜란//////////////////////
        initialSetting();

        ///////////////////예원//////////////////////

    }

    // Update is called once per frame
    void Update()
    {
        ///////////////////혜란//////////////////////
        checkScore7();

        text_score.text = score + "";
        text_multiple.text = multiple + "";

        if (multiple > 1)
        {
            ob_X.SetActive(true);
            ob_multiple.SetActive(true);
        }
        ///////////////////예원//////////////////////

    }

    ///////////////////혜란//////////////////////
    void initialSetting()
    {
        score = 0;
        multiple = 1;
        ob_X.SetActive(false);
        ob_multiple.SetActive(false);
        ob_goorstop.SetActive(false);
        ob_gobtn.SetActive(false);
        ob_stopbtn.SetActive(false);

        state_7 = false;
        temp = 0;
        go_num = 0;
        mine = 0;
        spectroscopy = false;
        dan = 0;
        hongdan = 0;
        chungdan = 0;
        chodan = 0;

        go1_state = 0;
        go2_state = 0;
        go3_state = 0;
        go4_state = 0;
        go5_state = 0;
        go6_state = 0;
        go7_state = 0;
        go8_state = 0;

    ////////예원 추가///////
    godori = 0;
        tens = 0;
        pi = 0;
        double_pi = false;

    }
    /*
1. 광
> 3장 3점(단, 비광 포함 시 2점) ‘삼광’
> 4장 4점 ‘사광’, 5장 5점 ‘오광’
      */
    public void getMine()
    {
        mine++;

        if (mine == 3)
        {
            if (spectroscopy)
            {
                score = score + 2;
            }
            else
            {
                score = score + 3;
            }
            mine3_UI.SetActive(true);
            Invoke("mine3", 1f);
            if (state_7) goStop();
        }
        if (mine == 4)
        {
            if (spectroscopy)
            {
                score = score + 2;
            }
            else
            {
                score = score + 1;
            }
            mine4_UI.SetActive(true);
            Invoke("mine4", 1f);
            if (state_7) goStop();
        }
        if (mine == 5)
        {
            score = score + 1;
            mine5_UI.SetActive(true);
            Invoke("mine5", 1f);
            if (state_7) goStop();
        }
    }
    void mine3()
    {
        mine3_UI.SetActive(false);
    }
    void mine4()
    {
        mine4_UI.SetActive(false);
    }
    void mine5()
    {
        mine5_UI.SetActive(false);
    }
    /*
4. 띠
> 5장 1점
> ‘청단’ 3장 3점
> ‘홍단’ 3장 3점
> ‘초단’ 3장 3점
     */
    public void getDan()
    {
        dan++;
        if (dan == 5)
        {
            score++;
            dan5_UI.SetActive(true);
            Invoke("dan5", 1f);
            if (state_7) goStop();
        }
    }
    public void getHongdan()
    {
        hongdan++;
        if (hongdan == 3)
        {
            score++;
            hongdan_UI.SetActive(true);
            Invoke("hongdan_", 1f);
            if (state_7) goStop();
        }
    }
    public void getChungdan()
    {
        chungdan++;
        if (chungdan == 3)
        {
            score++;
            chungdan_UI.SetActive(true);
            Invoke("chungdan_", 1f);
            if (state_7) goStop();
        }
    }
    public void getChodan()
    {
        chodan++;
        if (chodan == 3)
        {
            score++;
            chodan_UI.SetActive(true);
            Invoke("chodan_", 1f);
            if (state_7) goStop();
        }
    }
    void dan5()
    {
        dan5_UI.SetActive(false);
    }
    void chodan_()
    {
        chodan_UI.SetActive(false);
    }
    void hongdan_()
    {
        hongdan_UI.SetActive(false);
    }
    void chungdan_()
    {
        chungdan_UI.SetActive(false);
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
            if (temp == 0)
            {
                goStop();
                temp = 1;
            }
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
        Debug.Log("goScore에 들어오는지");
        ob_goorstop.SetActive(false);
        ob_gobtn.SetActive(false);
        ob_stopbtn.SetActive(false);

        switch (go_num)
        {
            case 0: // 1고
                go_num = 1;
                score++;
                go1_UI.SetActive(true);
                Invoke("go1_", 1f);
                go1_state = 1;
                break;
            case 1: // 2고
                go_num = 2;
                score++;
                go2_UI.SetActive(true);
                Invoke("go2_", 1f);
                go2_state = 1;
                break;
            case 2: // 3고
                go_num = 3;
                multiple = multiple * 2;
                go3_UI.SetActive(true);
                Invoke("go3_", 1f);
                go3_state = 1;
                break;
            case 3: // 4고
                go_num = 4;
                multiple = multiple * 2;
                go4_UI.SetActive(true);
                Invoke("go4_", 1f);                
                go4_state = 1;
                break;
            case 4: // 5고
                go_num = 5;
                multiple = multiple * 2;
                go5_UI.SetActive(true);
                Invoke("go5_", 1f);
                go5_state = 1;
                break;
            case 5: // 6고
                go_num = 6;
                multiple = multiple * 2;
                go6_UI.SetActive(true);
                Invoke("go6_", 1f);
                go6_state = 1;
                break;
            case 6: // 7고
                go_num = 7;
                multiple = multiple * 2;
                go7_UI.SetActive(true);
                Invoke("go7_", 1f);
                go7_state = 1;
                break;
            case 7: // 8고
                go_num = 8;
                multiple = multiple * 2;
                go8_UI.SetActive(true);
                Invoke("go8_", 1f);
                go8_state = 1;
                break;
        }

        
    }

    void goResultScene()
    {
        total_score = score * multiple;
        ResultScore.result = total_score;
        SceneManager.LoadScene("ResultScene"); //이거 밑줄 떠서 그냥 내가 고쳤어!
    }
    void go1_()
    {
        go1_UI.SetActive(false);
    }
    void go2_()
    {
        go2_UI.SetActive(false);
    }
    void go3_()
    {
        go3_UI.SetActive(false);
    }
    void go4_()
    {
        go4_UI.SetActive(false);
    }
    void go5_()
    {
        go5_UI.SetActive(false);
    }
    void go6_()
    {
        go6_UI.SetActive(false);
    }
    void go7_()
    {
        go7_UI.SetActive(false);
    }
    void go8_()
    {
        go8_UI.SetActive(false);
    }
    ///////////////////예원//////////////////////
    /////고도리 열끗 관계 생각 해 보기 (둘 다 동시에 + ?)
    /*
    3. 고도리
    고도리 3장 > 5점
    */
    public void getGodori()
    {
        godori++;
        if (godori == 3)
        {
            score = score + 5;
            godori_UI.SetActive(true);
            Invoke("godori_", 1f);
            if (state_7) goStop();
        }
    }
    void godori_()
    {
        godori_UI.SetActive(false);
    }
    //멍따 x2 어디에 추가할지
    /*
    2. 열끗
    5장 > 1점
    6~9장 > 1장에 1점씩 추가
    */
    public void getTens()
    {
        tens++;
        if (tens == 5)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (tens == 6)
        {
            score = score + 1;
            if (state_7) goStop();
        }

        if (tens == 7) //멍따
        {
            score = score + 1;
            mung_dda = true;
            mung_UI.SetActive(true);
            Invoke("mung_", 1f);
            if (state_7) goStop();
        }
        if (tens == 8)
        {
            score = score + 1;
            mung_dda = true;
            if (state_7) goStop();
        }
        if (tens == 9)
        {
            score = score + 1;
            mung_dda = true;
            if (state_7) goStop();
        }

    }
    void mung_()
    {
        mung_UI.SetActive(false);
    }
    /*
    5. 피
    10장 > 1점
    11~22장 > 1장 당 1점 추가
    */
    //// 쌍피 계산? 증가 하는게 +1 일지,,,,
    public void getPi()
    {//두번째 부터 +2 안되는거
        Debug.Log("getScore");
        Debug.Log(double_pi);
        if (double_pi)
        {
            pi = pi + 2;
        }
        else pi++;

        if (pi == 10)
        {
            pi_UI.SetActive(true);
            Invoke("pi_", 1f);
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 11)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 12)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 13)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 14)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 15)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 16)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 17)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 18)
        {
            score = score + 1;
            if (state_7) goStop();
        }
        if (pi == 19)
        {
            score = score + 1;
            if (state_7) goStop();
            
        }
        if (pi == 20)
        {
            score = score + 1;
            if (state_7) goStop();

        }
        if (pi == 21)
        {
            score = score + 1;
            if (state_7) goStop();

        }
        if (pi == 22)
        {
            score = score + 1;
            if (state_7) goStop();

        }


        //22까지 할지 말지


    }
    void pi_()
    {
        pi_UI.SetActive(false);
    }

}
