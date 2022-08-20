using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public void ClickRound()
    {
        ChangeSceneManager.Instance.SceneChange("RoundScene");
    }

    public void ClickTuto()
    {
        ChangeSceneManager.Instance.SceneChange("TutorialScene");
    }
}
