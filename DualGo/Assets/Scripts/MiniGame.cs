using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour {
    public GameObject canvas;
    public GameObject canvas_godori;
    public GameObject canvas_gwang;
    public GameObject canvas_ssang;
    public GameObject canvas_bingo;
    public GameObject canvas_wrong;

    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;

    public int godori;
    public int gwang;
    public int ssang;

    private int index;

    public void button1_click()
    {
        image1.SetActive(true);
        godori++;
        gwang++;
        ssang++;
    }
    public void button2_click()
    {
        image2.SetActive(true);
        godori++;
        gwang++;
        ssang++;
    }
    public void button3_click()
    {
        image3.SetActive(true);
        godori++;
        gwang++;
        ssang++;
    }
    public void button4_click()
    {
        image4.SetActive(true);
        gwang++;
    }
    public void button5_click()
    {
        image5.SetActive(true);
        gwang++;
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
