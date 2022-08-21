using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorial1btns;

    public Image CanvasImage;
    public Image finish;
    private bool isBtnMode = true;
    public Sprite secondSprite;
    public Sprite thirdSprite;
    private int thirdcount = 0;
    public GameObject thridBtn;
    public Sprite fourthSprite;
    public Image realcanvas;
    // public GameObject backobj;
    public Sprite fifthSprtie;
    public Sprite back;
    public Sprite sixSprite;
    public GameObject text;
    public GameObject images;
    public Sprite seventhSprite;
    // Start is called before the first frame upda;te
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
        Debug.Log(thirdcount);
        /*  if (thirdcount >= 1)
          {
              CanvasImage.sprite = fourthSprite;
          }*/


        switch (thirdcount)
        {
            case 0:
                CanvasImage.sprite = thirdSprite;
                break;
            case 1:
                CanvasImage.sprite = fourthSprite;
                realcanvas.gameObject.SetActive(true);
                realcanvas.sprite = back;
                break;
            case 2:
                CanvasImage.sprite = fifthSprtie;
                realcanvas.sprite = back;

                break;
            case 3:
                CanvasImage.sprite = sixSprite;
                realcanvas.sprite = back;
                break;
            case 4:
                CanvasImage.gameObject.SetActive(false);
                images.SetActive(true);
                text.SetActive(true);
                finish.gameObject.SetActive(true);
                break;

        }
        thirdcount++;



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
        ChangeSceneManager.Instance.SceneChange("TitleScene");
    }

}
