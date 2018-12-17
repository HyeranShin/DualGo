using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGame : MonoBehaviour {
    public GameObject canvas;
    public GameObject canvas_godori;
    public GameObject canvas_gwang;
    public GameObject canvas_ssang;
    public GameObject canvas_bingo;
    public GameObject canvas_wrong;

    public Button godori_wrong;
    public Button gwang_wrong;
    public Button ssang_wrong;

    public GameObject gd_image1;
    public GameObject gd_image2;
    public GameObject gd_image3;

    public GameObject gw_image1;
    public GameObject gw_image2;
    public GameObject gw_image3;
    public GameObject gw_image4;
    public GameObject gw_image5;

    public GameObject ss_image1;
    public GameObject ss_image2;
    public GameObject ss_image3;

    public Button gd_button1;
    public Button gd_button2;
    public Button gd_button3;

    public Button gw_button1;
    public Button gw_button2;
    public Button gw_button3;
    public Button gw_button4;
    public Button gw_button5;

    public Button ss_button1;
    public Button ss_button2;
    public Button ss_button3;

    private int godori;
    private int gwang;
    private int ssang;

    void Start()
    {
        canvas_godori.SetActive(false);
        canvas_gwang.SetActive(false);
        canvas_ssang.SetActive(false);
        gd_button1.onClick.AddListener(godori_1);
        gd_button2.onClick.AddListener(godori_2);
        gd_button3.onClick.AddListener(godori_3);
        godori_wrong.onClick.AddListener(click_wrong);

        gw_button1.onClick.AddListener(gw_button1_click);
        gw_button2.onClick.AddListener(gw_button2_click);
        gw_button3.onClick.AddListener(gw_button3_click);
        gw_button4.onClick.AddListener(gw_button4_click);
        gw_button5.onClick.AddListener(gw_button5_click);
        gwang_wrong.onClick.AddListener(click_wrong);

        ss_button1.onClick.AddListener(ss_button1_click);
        ss_button2.onClick.AddListener(ss_button2_click);
        ss_button3.onClick.AddListener(ss_button3_click);
        ssang_wrong.onClick.AddListener(click_wrong);

        godori = 0;
        gwang = 0;
        ssang = 0;
    }
    
    public void godori_1()
    {
        gd_image1.SetActive(true);
        godori++;
        Debug.Log(godori);
    }
    public void godori_2()
    {
        gd_image2.SetActive(true);
        godori++;
        Debug.Log(godori);
    }
    public void godori_3()
    {
        gd_image3.SetActive(true);
        godori++;
        Debug.Log(godori);
    }
    public void count3()
    {
        gd_image3.SetActive(true);
        godori++;
        Debug.Log(godori);
    }

    public void gw_button1_click()
    {
        gw_image1.SetActive(true);
        gwang++;
    }
    public void gw_button2_click()
    {
        gw_image2.SetActive(true);
        gwang++;
    }
    public void gw_button3_click()
    {
        gw_image3.SetActive(true);
        gwang++;
    }
    public void gw_button4_click()
    {
        gw_image4.SetActive(true);
        gwang++;
    }
    public void gw_button5_click()
    {
        gw_image5.SetActive(true);
        gwang++;
    }

    public void ss_button1_click()
    {
        ss_image1.SetActive(true);
        ssang++;
    }
    public void ss_button2_click()
    {
        ss_image2.SetActive(true);
        ssang++;
    }
    public void ss_button3_click()
    {
        ss_image3.SetActive(true);
        ssang++;
    }


    public void click_godori()
    {
        canvas.SetActive(false);
        canvas_godori.SetActive(true);
    }
    public void click_gwang()
    {
        canvas.SetActive(false);
        canvas_gwang.SetActive(true);
    }
    public void click_ssang()
    {
        canvas.SetActive(false);
        canvas_ssang.SetActive(true);
    }
    public void click_wrong()
    {
        canvas_wrong.SetActive(true);

    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            canvas_wrong.SetActive(false);
        }

        if (godori == 3)
        {
            canvas_bingo.SetActive(true);
        }
        if (gwang == 5)
        {
            canvas_bingo.SetActive(true);
        }
        if (ssang == 3)
        {
            canvas_bingo.SetActive(true);
            Debug.Log(ssang);
        }

    }
}
