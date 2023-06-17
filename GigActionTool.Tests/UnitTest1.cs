namespace GigActionTool.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WeatherForecast_ReturnsCalculatedTemperature()
        {
            var temperature = 1;
            var forecast = new WeatherForecast(new DateOnly(2021, 1, 1), temperature, "Whatever");
            var expected = 31 + (int)(temperature / 0.5556);
            Assert.That(expected == forecast.TemperatureF);
        }
    }
}