using NUnit.Framework;
using HelloRest.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using HelloRest;

namespace TestRest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWeatherForecastGet()
        {
            var controller = new WeatherForecastController(null);
            var result =  controller.Get();
            List<WeatherForecast> s = result.ToList();
            Assert.IsTrue( s.Count == 4);
        }
    }
}