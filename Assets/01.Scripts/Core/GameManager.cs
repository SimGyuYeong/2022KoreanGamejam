using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
[SerializeField]
class CardList
{
    public Card[] Cards; 
}
public class GameManager : MonoSingleton<GameManager>
{
    public List<Card> cardList = new List<Card>();  //전체카드

    public Player player1 = new Player();
    public Player player2 = new Player();

    private void Awake()
    {
        //       string jsonData = JsonConvert.SerializeObject(cardList);
        string saveData = File.ReadAllText(Path.Combine(Application.dataPath, "Cards.json"));
        Card[] cardListArray = { };
       cardList =  JsonConvert.DeserializeObject<List<Card>>(saveData);
     
        Shuffle();
    }

    private void Start()
    {
        for(int i = 0; i < 1; i ++)
        {
            player1.AddCard(ChooseCard());
            player2.AddCard(ChooseCard());
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            player1.AddCard(ChooseCard());
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            player2.AddCard(ChooseCard());
        }
    }

    public Card ChooseCard()
    {
        Card card = cardList[0];
        cardList.Remove(card);
        return card;
    }

    public void Shuffle()
    {
        int idx1, idx2;
        Card tempCard;

        //100번 정도 섞음
        for (int i = 0; i < 100; i++)
        {
            idx1 = Random.Range(0, 47);
            idx2 = Random.Range(0, 47);
            tempCard = cardList[idx1];
            cardList[idx1] = cardList[idx2];
            cardList[idx2] = tempCard;
        }
    }
}
