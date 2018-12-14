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
    public GameObject image;

	public void mini_click()
    {
        image.SetActive(true);
        
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
    }
}
