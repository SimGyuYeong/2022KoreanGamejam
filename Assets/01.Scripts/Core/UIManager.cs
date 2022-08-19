using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoSingleton<UIManager>
{
    public RectTransform[] playerCardInv = { };
    public GameObject cardPrefab;

    public void AddCardUI(int pNum, Card card)
    {
        var aCard = Instantiate(cardPrefab, playerCardInv[pNum].transform);
        aCard.GetComponentInChildren<TextMeshProUGUI>().text = card.cardName;
    }
}
