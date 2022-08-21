using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class RoundInform : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int roundNum;
    public bool isOpen = false;
    private Button _button;
    private Image _image;

    public Sprite defaultImage;
    public Sprite rockedImage;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        if(roundNum <= RoundManager.Instance.round)
        {
            _button.enabled = true;
            _image.sprite = defaultImage;
        }
        else
        {
            _button.enabled = false;
            _image.sprite = rockedImage;
        }
    }

    public void ClickRound()
    {
        RoundManager.Instance.SelectRound(roundNum);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(Vector3.one * 230, 0.1f);
        SoundManager.Instance.PlayEffectSound(SoundManager.Instance.zodiacEnterSource);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(Vector3.one * 200, 0.1f);
    }
}
