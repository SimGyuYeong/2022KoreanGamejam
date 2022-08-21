using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private Transform genalogyObj;
    [SerializeField] private Transform exitUI;

    private void Start()
    {
        SoundManager.Instance.PlayBgmSound(SoundManager.Instance.lobbySound);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ShowExitUI();
        }
    }

    public void ShowExitUI()
    {
        exitUI.DOScale(Vector3.one, 0.2f);
    }

    public void HideExitUI()
    {
        exitUI.DOScale(Vector3.zero, 0.2f);
    }

    public void GameExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }

    public void ClickRound()
    {
        ChangeSceneManager.Instance.SceneChange("RoundScene");
    }

    public void ClickTuto()
    {
        ChangeSceneManager.Instance.SceneChange("TutorialScene");
    }

    public void ClickGenalogy()
    {
        genalogyObj.DOScale(Vector3.one, 0.2f);
        genalogyObj.Find("Background").GetComponent<Image>().DOFade(1, 0.2f);
        genalogyObj.Find("Genalogy").GetComponent<Image>().DOFade(1, 0.2f);
    }

    public void CloseGenalogy()
    {
        genalogyObj.DOScale(Vector3.zero, 0.2f);
        genalogyObj.Find("Background").GetComponent<Image>().DOFade(0, 0.2f);
        genalogyObj.Find("Genalogy").GetComponent<Image>().DOFade(0, 0.2f);
    }
}
