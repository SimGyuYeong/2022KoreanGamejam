using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;


public class CardObj : PoolableMono
{
    public Card card;
    public SpriteRenderer spriteRenderer;
    public PRS originPRS;
    private GameObject _outline;

    private bool _isSelected = false;
    public bool IsSelected
    {
        get => _isSelected;
        set
        {
            _isSelected = value;
            _outline.SetActive(value);
        }
    }

    private void Awake()
    {
        spriteRenderer = transform.Find("Sprite").GetComponent<SpriteRenderer>();
        _outline = transform.Find("Outline").gameObject;
    }

    public void Setup(Card card)
    {
        this.card = card;
        spriteRenderer.sprite = UIManager.Instance.cardSprite[card.spriteNum];
        if(GameManager.Instance.isGameStart == true)
            spriteRenderer.sprite = UIManager.Instance.backCardSprite;
    }

    public void MoveTrm(PRS prs, bool isDotween, float time = 0)
    {
        if(isDotween)
        {
            transform.DOMove(prs.pos, time);
            transform.DORotateQuaternion(prs.rot, time);
            transform.DOScale(prs.scale, time);
        }
        else
        {
            transform.position = prs.pos;
            transform.rotation = prs.rot;
            transform.localScale = prs.scale;
        }
    }

    public override void Reset()
    {
        IsSelected = false;
        transform.localScale = Vector3.one * 0.5f;
    }

    public void Destroy()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InOutQuad));
        seq.AppendCallback(() => PoolManager.Instance.Push(this));
    }

    private void OnMouseOver()
    {
        if(GameManager.Instance.isLoading == false)
            CardManager.Instance.CardMouseOver(this);
    }

    private void OnMouseExit()
    {
        if (GameManager.Instance.isLoading == false)
            CardManager.Instance.CardMouseExit(this);
    }

    public void OnMouseDown()
    {
        if (GameManager.Instance.isLoading == false)
            CardManager.Instance.CardClick(this);
    }

    public void OnMouseUp()
    {
        if (GameManager.Instance.isLoading == false)
            CardManager.Instance.CardMouseUp();
    }

    
}
