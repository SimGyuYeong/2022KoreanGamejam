using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    public Text text;
    private AudioSource audioSource;
    public string star;
    private ScriptData _scriptData = new ScriptData();
    private List<Script> script;
    public Sprite yang;
    public Sprite saza;
    public Sprite mulbyeong;
    public Sprite ge;
    public Sprite mulgogi;
    public Sprite sasu;
    public Sprite ssangdongyi;
    public Sprite yeomso;
    public Sprite jeongal;
    public Sprite cheonyeo;
    public Sprite cheonching;
    public Sprite hwangso;
    public Image icon;
    private AudioClip clip;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        star = PlayerPrefs.GetString("star");
        switch (star)
        {
            case "yang" : script = _scriptData.YangScript; _scriptData.InitializeYang();
                icon.sprite = yang;
                StartCoroutine(soundCoroutine());
                break;
            case "hwangso" : script = _scriptData.HwangsoScript;
                icon.sprite = hwangso;
                _scriptData.InitializeHwangso();
                StartCoroutine(soundCoroutine());
                break;
            case "ssangdongyi" : script = _scriptData.SsangdongyiScript;
                _scriptData.Initializessangdongyi();
                icon.sprite = ssangdongyi;
                StartCoroutine(soundCoroutine());
                break;
            case "ge" : script = _scriptData.GeScript;
                _scriptData.Initializege();
                icon.sprite = ge;
                StartCoroutine(soundCoroutine());
                break;
            case "saza" : script = _scriptData.SazaScript; _scriptData.Initializesaza();
                icon.sprite = saza;
                StartCoroutine(soundCoroutine());
                break;
            case "cheonyeo" : script = _scriptData.CheonyeoScript;
                _scriptData.InitializeCheonyeo();
                icon.sprite = cheonyeo;
                StartCoroutine(soundCoroutine());
                break;
            case "cheonching" : script = _scriptData.CheonchingScript;
                _scriptData.InitializeCheoncing();
                icon.sprite = cheonching;
                StartCoroutine(soundCoroutine());
                break;
            case "jeongal" : script = _scriptData.JeongalScript;
                _scriptData.InitializeJeongal();
                icon.sprite = jeongal;
                StartCoroutine(soundCoroutine());
                break;
            case "sasu" : script = _scriptData.SasuScript;
                _scriptData.InitializeSasu();
                icon.sprite = sasu;
                StartCoroutine(soundCoroutine());
                break;
            case "yeomso" : script = _scriptData.YeomsoScript;
                _scriptData.InitializeYeomso();
                icon.sprite = yeomso;
                StartCoroutine(soundCoroutine());
                break;
            case "mulbyeong" : script = _scriptData.MulbyeongScript;
                icon.sprite = mulbyeong;
                _scriptData.InitializeMulbyeong();
                StartCoroutine(soundCoroutine());
                break;
            case "mulgogi" : script = _scriptData.MulgogiScript;
                _scriptData.InitializeMulgogi();
                icon.sprite = mulbyeong;
                StartCoroutine(soundCoroutine());
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    IEnumerator soundCoroutine()
    {
        yield return new WaitForSeconds(1f);
        foreach (Script varscript in script)
        {
            text.text = varscript.script;
            startSound(varscript.fileName);
            yield return new WaitForSeconds(clip.length);
            
        }

        ChangeSceneManager.Instance.SceneChange("CardScene");
    }

    void startSound(string num)
    {
       // audioSource = new AudioSource();
        clip = Resources.Load<AudioClip>("StoryDubbing/" + star + "/" + num.FirstOrDefault());
        Debug.Log(clip);
        audioSource.clip = clip;
        audioSource.Play();

    }// Update is called once per frame"
    void Update()
    {
        
    }
}
