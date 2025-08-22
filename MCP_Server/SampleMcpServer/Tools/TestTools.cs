using SampleMcpServer.Tools;

class TestTools
{
    static void Main()
    {
        var randomTool = new RandomNumberTools();
        Console.WriteLine($"Random Number: {randomTool.GetRandomNumber(1, 10)}");

        var weatherTool = new WeatherTools();
        Console.WriteLine(weatherTool.GetCityWeather("Delhi"));
    }
}
