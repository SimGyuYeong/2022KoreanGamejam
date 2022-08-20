using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitManager : MonoBehaviour
{
    private void Start()
    {
        ChangeSceneManager.Instance.SceneChange("TitleScene");
    }
}
