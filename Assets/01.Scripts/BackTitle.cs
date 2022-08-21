using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTitle : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeSceneManager.Instance.SceneChange("TitleScene");
        }
    }
}
