using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;


public class CardObj : MonoBehaviour
{
    public Card card;
    public SpriteRenderer spriteRenderer;
    public PRS originPRS;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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

    private void OnMouseOver()
    {
        CardManager.Instance.CardMouseOver(this);
    }

    private void OnMouseExit()
    {
        CardManager.Instance.CardMouseExit(this);
    }
}
