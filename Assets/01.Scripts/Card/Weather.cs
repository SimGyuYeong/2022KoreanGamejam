using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather
{
    private string _weatherName;
    public int weatherId; //�� ���� ���� �ܿ� ->  1, 2, 3, 4

    public Weather(int Id )
    {
        weatherId = Id;
        switch(Id)
        {
            case 1: _weatherName = "��"; break;
            case 2: _weatherName = "����"; break;
            case 3: _weatherName = "����"; break;
            case 4: _weatherName = "�ܿ�"; break;
        }
    }
     public int GetWeatherId()
    {
        return weatherId;
    }
    public string GetWeatherName()
    {
        return _weatherName;
    }
}
