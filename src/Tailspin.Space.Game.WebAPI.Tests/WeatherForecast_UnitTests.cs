namespace Tailspin.Space.Game.WebAPI.Tests {
    public class WeatherForecast_UnitTests {
        [Theory]
        [InlineData(1, 33)]
        [InlineData(5, 40)]
        [InlineData(17, 62)]
        public void WeatherForecast_TemperatureFahrenheit_SuccessCalculate(int temperatureCelsius, int temperatureFahrenheit) {
            var weatherForecast = new WeatherForecast();
            weatherForecast.TemperatureC = temperatureCelsius;

            Assert.Equal(temperatureFahrenheit,  weatherForecast.TemperatureF);
        }
    }
}