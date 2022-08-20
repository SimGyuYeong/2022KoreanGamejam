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
    int startCardCnt = 10;
    public bool isFastMode = false;

    public enum TurnMode
    {
        Random,
        Player1,
        Player2
    }
    WaitForSeconds delay = new WaitForSeconds(0.5f);

    public static Action<Player> OnAddCard;

    [Header("Player")]
    private Player _turnPlayer;
    public Player player1 = new Player();
    public Player player2 = new Player();

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
            CardManager.Instance.AddCard(_turnPlayer);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (_turnPlayer == player1)
            {
                _turnPlayer = player2;
                CardManager.Instance.cardSpawnPosition.DOLocalRotate(new Vector3(0, 0, 360), 0);
                Camera.main.transform.DOLocalRotate(new Vector3(0, 0, 180), 0.5f);
            }
            else
            {
                _turnPlayer = player1;
                CardManager.Instance.cardSpawnPosition.DOLocalRotate(new Vector3(0, 0, 180), 0);
                Camera.main.transform.DOLocalRotate(new Vector3(0, 0, 360), 0.5f);
            }
        }
    }

    public void GameSetup()
    {
        switch(turnMode)
        {
            case TurnMode.Random:
                int random = Random.Range(0, 2);
                _turnPlayer = random == 0 ? player1 : player2;
                break;
            case TurnMode.Player1:
                _turnPlayer = player1;
                break;
            case TurnMode.Player2:
                _turnPlayer = player2;
                break;
        }
    }

    public IEnumerator StartGameCoroutine()
    {
        GameSetup();

        if (isFastMode) delay = new WaitForSeconds(0.05f);

        for(int i = 0; i < startCardCnt; i++)
        {
            yield return delay;
            OnAddCard?.Invoke(player1);
            yield return delay;
            OnAddCard?.Invoke(player2);
        }
    }
}
