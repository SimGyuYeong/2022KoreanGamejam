using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Star
{
    Fire,
    Dirt,
    Air,
    Water
}

[System.Serializable]
public class Card
{
    public Weather weather;
    public Star star;
    public string cardName;
    public string zodiac; //º°ÀÚ¸®
}

