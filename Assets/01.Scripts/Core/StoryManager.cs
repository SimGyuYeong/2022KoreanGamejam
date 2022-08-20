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
    public Sprite yang1;
    public Sprite saza;
    public Sprite saza1;
    public Sprite mulbyeong;
    public Sprite mulbyeong1;
    public Sprite ge;
    public Sprite ge1;
    public Sprite mulgogi;
    public Sprite mulgogi1;
    public Sprite sasu;
    public Sprite sasu1;
    public Sprite ssangdongyi;
    public Sprite ssangdongyi1;
    public Sprite yeomso;
    public Sprite yeomso1;
    public Sprite jeongal;
    public Sprite jeongal1;
    public Sprite cheonyeo;
    public Sprite cheonyeo1;
    public Sprite cheonching;
    public Sprite cheonching1;
    public Sprite hwangso;
    public Sprite hwangso1;
    public Image icon;
    public Image icon2;
    private AudioClip clip;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        star = PlayerPrefs.GetString("star");
        switch (star)
        {
            case "yang" : script = _scriptData.YangScript; _scriptData.InitializeYang();
                icon.sprite = yang;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "hwangso" : script = _scriptData.HwangsoScript;
                icon.sprite = hwangso;
                icon2.sprite = yang1;
                _scriptData.InitializeHwangso();
                StartCoroutine(soundCoroutine());
                break;
            case "ssangdongyi" : script = _scriptData.SsangdongyiScript;
                _scriptData.Initializessangdongyi();
                icon.sprite = ssangdongyi;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "ge" : script = _scriptData.GeScript;
                _scriptData.Initializege();
                icon.sprite = ge;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "saza" : script = _scriptData.SazaScript; _scriptData.Initializesaza();
                icon.sprite = saza;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "cheonyeo" : script = _scriptData.CheonyeoScript;
                _scriptData.InitializeCheonyeo();
                icon.sprite = cheonyeo;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "cheonching" : script = _scriptData.CheonchingScript;
                _scriptData.InitializeCheoncing();
                icon.sprite = cheonching;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "jeongal" : script = _scriptData.JeongalScript;
                _scriptData.InitializeJeongal();
                icon.sprite = jeongal;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "sasu" : script = _scriptData.SasuScript;
                _scriptData.InitializeSasu();
                icon.sprite = sasu;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "yeomso" : script = _scriptData.YeomsoScript;
                _scriptData.InitializeYeomso();
                icon.sprite = yeomso;
                icon2.sprite = yang1;
                StartCoroutine(soundCoroutine());
                break;
            case "mulbyeong" : script = _scriptData.MulbyeongScript;
                icon.sprite = mulbyeong;
                icon2.sprite = yang1;
                _scriptData.InitializeMulbyeong();
                StartCoroutine(soundCoroutine());
                break;
            case "mulgogi" : script = _scriptData.MulgogiScript;
                _scriptData.InitializeMulgogi();
                icon.sprite = mulbyeong;
                icon2.sprite = yang1;
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
        audioSource.clip = clip;
        audioSource.Play();

    }// Update is called once per frame"
    void Update()
    {
        
    }
}
