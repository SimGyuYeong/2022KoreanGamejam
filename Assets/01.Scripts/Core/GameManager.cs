using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using DG.Tweening;
using System;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int round = 0;

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
    private int _turnPlayerNum;
    public Player TurnPlayer
    {
        get =>_turnPlayerNum == 1 ? player1 : player2;
        set
        {
            if (value == player1) _turnPlayerNum = 1;
            else _turnPlayerNum = 2;
        }
    }
    public Player player1 = new Player();
    public Player player2 = new Player();

    public GameObject canvas;
    public PoolingListSO _initList;

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
        Instance = this;

        //       string jsonData = JsonConvert.SerializeObject(cardList);
        string saveData = File.ReadAllText(Path.Combine(Application.dataPath, "Cards.json"));
        Card[] cardListArray = { };
        CardManager.Instance.cardList =  JsonConvert.DeserializeObject<List<Card>>(saveData);

        CreatePool();
        CardManager.Instance.Shuffle();
    }

    private void Start()
    {
        round = RoundManager.Instance.round;
        StartCoroutine(StartGameCoroutine());
    }

    public void EndRound()
    {
        RoundManager.Instance.round++;
        ChangeSceneManager.Instance.SceneChange("RoundScene");
    }

    public void SelectCard()
    {
        if(isLoading == false)
        {
            CardManager.Instance.AddCard(TurnPlayer);
        }
    }

    private void CreatePool()
    {
        foreach (PoolingPair pair in _initList.list)
        {
            PoolManager.Instance.CreatePool(pair.prefab, pair.poolCnt);
        }
    }

    public void GameSetup()
    {
        switch(turnMode)
        {
            case TurnMode.Random:
                int random = Random.Range(0, 2);
                TurnPlayer = random == 0 ? player1 : player2;
                break;
            case TurnMode.Player1:
                TurnPlayer = player2;
                break;
            case TurnMode.Player2:
                TurnPlayer = player1;
                break;
        }
    }

    public void EndTurn()
    {
        StartCoroutine(NextTurnCoroutine());
    }

    /// <summary>
    /// 게임 시작 코루틴 함수
    /// </summary>
    /// <returns></returns>
    public IEnumerator StartGameCoroutine()
    {
        yield return new WaitForSeconds(2f);
        isLoading = true;
        GameSetup();
        UIManager.Instance.ScoreUpdate();

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
            StartCoroutine(TurnPlayer.CardFlipCoroutine());

        if(player1.score >= 30)
        {
            Debug.Log("Player1 Win");
        }
        else if(player2.score >= 30)
        {
            Debug.Log("Player2 Win");
        }
        else if(CardManager.Instance.cardList.Count == 0)
        {
            if(player1.score > player2.score)
            {
                Debug.Log("Player1 Win");
            }
            else
            {
                Debug.Log("Player2 Win");
            }
        }

        foreach(CardObj card in CardManager.Instance.selectCardList)
        {
            card.IsSelected = false;
        }
        CardManager.Instance.selectCardList.Clear();

        yield return new WaitForSeconds(TurnPlayer.GetFlipTime());

        if (TurnPlayer == player1)
        {
            TurnPlayer = player2;
            MainCam.transform.DOLocalRotate(new Vector3(0, 0, 180), 0.5f);
            canvas.transform.DOLocalRotate(new Vector3(0, 0, 180), 0.5f);
        }
        else
        {
            TurnPlayer = player1;
            MainCam.transform.DOLocalRotate(new Vector3(0, 0, 360), 0.5f);
            canvas.transform.DOLocalRotate(new Vector3(0, 0, 360), 0.5f);
        }

        yield return new WaitForSeconds(0.6f);
        StartCoroutine(TurnPlayer.CardFlipCoroutine());
        yield return new WaitForSeconds(TurnPlayer.GetFlipTime());
        // 턴 메세지 안내
        Debug.Log($"{TurnPlayer} 턴");
        yield return new WaitForSeconds(0.5f);
        isLoading = false;
        if (isGameStart == true) isGameStart = false;
    }
}
