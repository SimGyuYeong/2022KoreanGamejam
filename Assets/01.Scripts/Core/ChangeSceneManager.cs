using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoSingleton<ChangeSceneManager>
{
    [SerializeField] private SpriteRenderer _backgroundRenderer;

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
        _backgroundRenderer.DOFade(1, 0.4f);
        yield return new WaitForSeconds(0.4f);
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(scene);
        yield return new WaitForSeconds(1f);
        _backgroundRenderer.DOFade(0, 0.4f);
    }
}
