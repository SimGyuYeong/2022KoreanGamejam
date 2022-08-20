using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorial1btns;

    public Image CanvasImage;

    private bool isBtnMode = true;
    public Sprite secondSprite;
    public Sprite thirdSprite;
    private int thirdcount = 0;
    public GameObject thridBtn;

    public Sprite fourthSprite;
    // Start is called before the first frame update
    void Start()
    {
        thridBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void ClickThird()
    {
        Debug.Log("클릭... 된거이가?");
        if (thirdcount >= 1)
        {
            CanvasImage.sprite = fourthSprite;
        }
        else 
        {
            CanvasImage.sprite = thirdSprite;
            thirdcount++;
        }
       
        
    }

    public void clickgotoSecond()
    {
        tutorial1btns.SetActive(false);
        Debug.Log("눌림!");
        CanvasImage.sprite = secondSprite;
        thridBtn.SetActive(true);
    }

    public void Skip()
    {
        
    }
    
}
