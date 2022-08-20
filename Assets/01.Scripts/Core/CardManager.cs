using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[SerializeField]
class CardList
{
    public Card[] Cards;
}

public class CardManager : MonoSingleton<CardManager>
{
    public List<Card> cardList = new List<Card>();  //��üī��
    public GameObject cardPrefab;
    public Transform cardSpawnPosition;

    public Transform player1CardLeft;
    public Transform player1CardRight;
    public Transform player2CardLeft;
    public Transform player2CardRight;

    private void Start()
    {
        GameManager.OnAddCard += AddCard;
    }

    private void OnDestroy()
    {
        GameManager.OnAddCard -= AddCard;
    }

    public Card PopCard()
    {
        Card card = cardList[0];
        cardList.Remove(card);
        return card;
    }

    public void AddCard(Player player)
    {
        var cardObj = Instantiate(cardPrefab, cardSpawnPosition.position, Quaternion.identity);
        if(player == GameManager.Instance.player2) cardObj.transform.DOLocalRotate(new Vector3(0, 0, 180), 0);
        CardObj card = cardObj.GetComponent<CardObj>();
        card.Setup(PopCard());
        player.cards.Add(card);

        SetOriginOrder(player);
        CardAlignment(player);
    }

    private void CardAlignment(Player player)
    {
        List<PRS> originPRSs = new List<PRS>();
        if(player == GameManager.Instance.player1)
        {
            originPRSs = RoundAligment(player1CardLeft, player1CardRight, player.cards.Count, 0.5f, Vector3.one * 0.5f);
        }
        else
        {
            originPRSs = RoundAligment(player2CardLeft, player2CardRight, player.cards.Count, -0.5f, Vector3.one * 0.5f);
        }

        for (int i = 0; i < player.cards.Count; i++)
        {
            var targetCard = player.cards[i];
            targetCard.originPRS = originPRSs[i];
            targetCard.MoveTrm(targetCard.originPRS, true, .7f);
        }
    }

    private List<PRS> RoundAligment(Transform leftTrm, Transform rightTrm, int count, float height, Vector3 scale)
    {
        float[] objLerps = new float[count];
        List<PRS> results = new List<PRS>(count);

        if(height < 0)
        {
            switch (count)
            {
                case 1: objLerps = new float[] { 0.5f }; break;
                case 2: objLerps = new float[] { 0.27f, 0.73f }; break;
                case 3: objLerps = new float[] { 0.1f, 0.5f, 0.9f }; break;
                default:
                    float interval = 1f / (count - 1f);
                    for (int i = 0; i < count; i++)
                        objLerps[i] = interval * i;
                    break;
            }
        }
        else
        {
            switch (count)
            {
                case 1: objLerps = new float[] { 0.5f }; break;
                case 2: objLerps = new float[] { 0.73f, 0.27f}; break;
                case 3: objLerps = new float[] { 0.9f, 0.5f, 0.1f }; break;
                default:
                    float interval = 1f / (count - 1f);
                    for (int i = count - 1, j = 0; i >= 0; i--, j++)
                        objLerps[j] = interval * i;
                    break;
            }
        }
        

        for(int i = 0; i < count; i++)
        {
            var targetPos = Vector3.Lerp(leftTrm.position, rightTrm.position, objLerps[i]);
            if (count >= 4)
            {
                float curve = Mathf.Sqrt(Mathf.Pow(height, 2) - Mathf.Pow(objLerps[i] - 0.5f, 2));
                curve = height >= 0 ? curve : -curve;
                targetPos.y = curve;
                targetPos.y -= height >= 0 ? 3.5f : -3.5f;
            }
            var targetRot = Quaternion.Slerp(leftTrm.rotation, rightTrm.rotation, count >= 4 ? objLerps[i] : 0.5f);

            results.Add(new PRS(targetPos, targetRot, scale));
        }
        return results;
    }

    public void SetOriginOrder(Player player)
    {
        int cnt = player.cards.Count;
        for (int i = 0; i < cnt; i++)
        {
            var targetCard = player.cards[i];
            targetCard.GetComponent<Order>().SetOriginOrder(i);
        }
    }

    public void Shuffle()
    {
        int idx1, idx2;
        Card tempCard;

        //100�� ���� ����
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
