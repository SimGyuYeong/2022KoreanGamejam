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

        string name = "yang";
        switch(round)
        { 
            case 1:
                name = "yang";
                break;
            case 2:
                name = "hwangso";
                break;
            case 3:
                name = "ssangdongyi";
                break;
            case 4:
                name = "ge";
                break;
            case 5:
                name = "saza";
                break;
            case 6:
                name = "cheonyeo";
                break;
            case 7:
                name = "cheonching";
                break;
            case 8:
                name = "jeongal";
                break;
            case 9:
                name = "sasu";
                break;
            case 10:
                name = "yeomso";
                break;
            case 11:
                name = "mulbyeong";
                break;
            case 12:
                name = "mulgogi";
                break;
        }
        PlayerPrefs.SetString("star", name);
        ChangeSceneManager.Instance.SceneChange("StoryScene");
    }
}
