using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundManager : MonoSingleton<RoundManager>
{
    public int round = 1;

    public int player1Score = 0;
    public int player2Score = 0;

    private void Awake()
    {
        var obj = FindObjectsOfType<RoundManager>();

        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SelectRound(int round)
    {
        this.round = round;
        ChangeSceneManager.Instance.SceneChange("CardScene");
    }
}
