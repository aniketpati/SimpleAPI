using Microsoft.Extensions.Logging;
using Moq;
using SimpleAPI.Controllers;

namespace SimpleAPI.test;

public class UnitTest1
{
    private readonly Mock<ILogger<WeatherForecastController>>? logger;

    public UnitTest1()
    {
        logger = new Mock<ILogger<WeatherForecastController>>();
    }
    [Fact]
    public void GetWeatherForecast()
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController(logger!.Object);
        var result = weatherForecastController.Get();
        Assert.IsType<WeatherForecast[]>(Mock.GetWeatherForecast());
    }
}