using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Weather
    {
        public int temperature;
        public string weatherType;
        public Weather()
        {

        }
        public void ChangeWeather()
        {
            Random random = new Random();
            Random random1 = new Random();
            temperature = random.Next(50, 100);
            ChangeWeatherType(random1.Next(1, 4));
        }
        public void ChangeWeatherType(int number)
        {
            switch (number)
            {
                case 1:
                    weatherType = "sunny";
                    break;
                case 2:
                    weatherType = "rainy";
                    break;
                default:
                    weatherType = "cloudy";
                    break;
            }
        }
    }
}
