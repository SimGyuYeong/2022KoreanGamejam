using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoSingleton<UIManager>
{
    public Sprite[] cardSprite;
    public Sprite backCardSprite;

    public TextMeshProUGUI cardCntText;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    public void CardCntUpdate()
    {
        cardCntText.text = CardManager.Instance.cardList.Count.ToString();
    }

    public void ScoreUpdate()
    {
        player1ScoreText.text = GameManager.Instance.player1.score.ToString();
        player2ScoreText.text = GameManager.Instance.player2.score.ToString();
    }
}
