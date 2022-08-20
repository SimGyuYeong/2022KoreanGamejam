using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using DG.Tweening;
using System;
using Random = UnityEngine.Random;

public class GameManager : MonoSingleton<GameManager>
{
    [Header("Turn")]
    public TurnMode turnMode;
    [SerializeField] int startCardCnt = 10;
    public bool isFastMode = false;
    public bool isLoading = false;
    public bool isGameStart = true;

    public enum TurnMode
    {
        Random,
        Player1,
        Player2
    }
    WaitForSeconds delay = new WaitForSeconds(0.5f);

    public static Action<Player> OnAddCard;

    [Header("Player")]
    public Player turnPlayer;
    public Player player1 = new Player();
    public Player player2 = new Player();

    // 카메라 불러오는게 메모리를 엄청 잡아먹어서 한번만 불러옴
    private static Camera _mainCam = null;
    public static Camera MainCam
    {
        get
        {
            if (_mainCam == null)
            {
                _mainCam = Camera.main;
            }
            return _mainCam;
        }
    }

    private void Awake()
    {
        //       string jsonData = JsonConvert.SerializeObject(cardList);
        string saveData = File.ReadAllText(Path.Combine(Application.dataPath, "Cards.json"));
        Card[] cardListArray = { };
       CardManager.Instance.cardList =  JsonConvert.DeserializeObject<List<Card>>(saveData);
     
        CardManager.Instance.Shuffle();
        StartCoroutine(StartGameCoroutine());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CardManager.Instance.AddCard(turnPlayer);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(NextTurnCoroutine());
        }
    }

    public void GameSetup()
    {
        switch(turnMode)
        {
            case TurnMode.Random:
                int random = Random.Range(0, 2);
                turnPlayer = random == 0 ? player1 : player2;
                break;
            case TurnMode.Player1:
                turnPlayer = player2;
                break;
            case TurnMode.Player2:
                turnPlayer = player1;
                break;
        }
    }

    /// <summary>
    /// 게임 시작 코루틴 함수
    /// </summary>
    /// <returns></returns>
    public IEnumerator StartGameCoroutine()
    {
        isLoading = true;
        GameSetup();

        if (isFastMode) delay = new WaitForSeconds(0.05f);

        for(int i = 0; i < startCardCnt; i++)
        {
            yield return delay;
            OnAddCard?.Invoke(player1);
            yield return delay;
            OnAddCard?.Invoke(player2);
        }

        yield return new WaitForSeconds(0.8f);
        StartCoroutine(player1.CardFlipCoroutine(true));
        StartCoroutine(player2.CardFlipCoroutine(true));
        StartCoroutine(NextTurnCoroutine());
    }

    /// <summary>
    /// 다음턴으로 넘어가는 코루틴 함수
    /// </summary>
    /// <returns></returns>
    public IEnumerator NextTurnCoroutine()
    {
        isLoading = true;
        if(isGameStart == false)
            StartCoroutine(turnPlayer.CardFlipCoroutine());

        yield return new WaitForSeconds(turnPlayer.GetFlipTime());

        if (turnPlayer == player1)
        {
            turnPlayer = player2;
            CardManager.Instance.cardSpawnPosition.DOLocalRotate(new Vector3(0, 0, 360), 0);
            MainCam.transform.DOLocalRotate(new Vector3(0, 0, 180), 0.5f);
        }
        else
        {
            turnPlayer = player1;
            CardManager.Instance.cardSpawnPosition.DOLocalRotate(new Vector3(0, 0, 180), 0);
            MainCam.transform.DOLocalRotate(new Vector3(0, 0, 360), 0.5f);
        }

        yield return new WaitForSeconds(0.6f);
        StartCoroutine(turnPlayer.CardFlipCoroutine());
        yield return new WaitForSeconds(turnPlayer.GetFlipTime());
        // 턴 메세지 안내
        Debug.Log($"{turnPlayer} 턴");
        yield return new WaitForSeconds(0.5f);
        isLoading = false;
        if (isGameStart == true) isGameStart = false;
    }
}
