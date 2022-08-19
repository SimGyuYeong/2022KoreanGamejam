using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather
{
    private string _weatherName;
    public int weatherId; //봄 여름 가을 겨울 ->  1, 2, 3, 4

    public Weather(int Id )
    {
        weatherId = Id;
        switch(Id)
        {
            case 1: _weatherName = "봄"; break;
            case 2: _weatherName = "여름"; break;
            case 3: _weatherName = "가을"; break;
            case 4: _weatherName = "겨울"; break;
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
