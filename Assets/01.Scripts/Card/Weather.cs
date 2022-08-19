public enum WeatherID
{
    Spring,
    Summer,
    Fall,
    Winter
}

[System.Serializable]
public class Weather
{
    private string _weatherName;
    public WeatherID weatherId; //봄 여름 가을 겨울 ->  1, 2, 3, 4

     public WeatherID GetWeatherId()
    {
        return weatherId;
    }
    public string GetWeatherName()
    {
        return _weatherName;
    }
}
