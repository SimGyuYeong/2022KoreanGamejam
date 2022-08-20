using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private Transform genalogyObj;

    private void Start()
    {
        SoundManager.Instance.PlayBgmSound(SoundManager.Instance.lobbySound);
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
