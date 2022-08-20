using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Sprite[] cardSprite;
    public Sprite backCardSprite;

    public TextMeshProUGUI cardCntText;

    public GameObject player1ScoreObj;
    public GameObject player2ScoreObj;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    public TextMeshProUGUI roundText;

    public GameObject exitObj;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        player1ScoreObj.transform.Find("Player1RoundScore").GetComponent<TextMeshProUGUI>().text = RoundManager.Instance.player1Score.ToString();
        player2ScoreObj.transform.Find("Player2RoundScore").GetComponent<TextMeshProUGUI>().text = RoundManager.Instance.player2Score.ToString();
    }

    public void CardCntUpdate()
    {
        cardCntText.text = CardManager.Instance.cardList.Count.ToString();
    }

    public void ScoreUpdate()
    {
        player1ScoreText.text = GameManager.Instance.player1.score.ToString();
        player2ScoreText.text = GameManager.Instance.player2.score.ToString();
    }

    public void RoundUpdate()
    {
        roundText.text = GameManager.Instance.round.ToString();
    }

    public void ShowExitUI()
    {
        exitObj.transform.DOScale(Vector3.one, 0.5f);
    }

    public void HiddenExitUI()
    {
        exitObj.transform.DOScale(Vector3.zero, 0.5f);
    }

    public void GameStop()
    {
        ChangeSceneManager.Instance.SceneChange("TitleScene");
    }

}
