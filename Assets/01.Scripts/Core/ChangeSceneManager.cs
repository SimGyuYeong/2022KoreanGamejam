using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneManager : MonoSingleton<ChangeSceneManager>
{
    private Image _backgroundImage;
    private Slider _slider;
    private GameObject _loadingObj;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        _backgroundImage = GetComponentInChildren<Image>();
        _slider = GetComponentInChildren<Slider>();
        _loadingObj = transform.Find("Canvas/LoadingObj").gameObject;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneChange("CardScene");
        }
    }

    public void SceneChange(string sceneName)
    {
        StartCoroutine(SceneChangeCoroutine(sceneName));
    }
     
    private IEnumerator SceneChangeCoroutine(string scene)
    {
        _backgroundImage.DOFade(1, 0.4f);
        _loadingObj.transform.DOScale(Vector3.one, 0.2f);
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(scene);
        _slider.DOValue(1f, 1.5f);
        yield return new WaitForSeconds(1.5f);
        _loadingObj.transform.DOScale(Vector3.zero, 0.2f);
        _backgroundImage.DOFade(0, 0.4f);
        _slider.value = 0;
    }
}
