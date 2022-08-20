using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoSingleton<RoundManager>
{
    public int round = 1;

    public int player1Score = 0;
    public int player2Score = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void SelectRound(int round)
    {
        this.round = round;
    }
}
