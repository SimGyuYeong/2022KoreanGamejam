using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;


public class CardObj : MonoBehaviour
{
    public Card card;
    public Sprite sprite;
    public PRS originPRS;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    public void Setup(Card card)
    {
        this.card = card;
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
}
