using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundInform : MonoBehaviour
{
    public int roundNum;
    public bool isOpen = false;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void Start()
    {
        if(roundNum <= RoundManager.Instance.round)
        {
            _button.enabled = true;
        }
        else
        {
            _button.enabled = false;
        }
    }

    public void ClickRound()
    {
        RoundManager.Instance.SelectRound(roundNum);
    }
}
