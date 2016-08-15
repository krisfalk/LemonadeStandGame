using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Customer
    {
        protected string type;
        public Customer()
        {
            
        }
        public string GetCustomerType()
        {
            return type;
        }
        public bool ToBuyOrNot(Inventory current, Weather currentDay)
        {
            if(CheckWeatherType(currentDay) < 60 && current.lemonadePrice <= 20)
            {
                //1 in 4 buys if amount of lemons and sugar per pitch are within 3
                //improves to 1 in 2 buys if ice per cup is with in 2 of ten total
                //everyone buys if there is 8 lemons, 8 sugar, and 10 ice cubes
            }
            else if (CheckWeatherType(currentDay) < 70 && current.lemonadePrice <= 25)
            {
                //1 in 4 buys if amount of lemons and sugar per pitch are within 3
                //improves to 1 in 2 buys if ice per cup is with in 2 of ten total
                //everyone buys if there is 8 lemons, 8 sugar, and 10 ice cubes
            }
            else if (CheckWeatherType(currentDay) < 80 && current.lemonadePrice <= 30)
            {
                //1 in 4 buys if amount of lemons and sugar per pitch are within 3
                //improves to 1 in 2 buys if ice per cup is with in 2 of ten total
                //everyone buys if there is 8 lemons, 8 sugar, and 10 ice cubes
            }
            else if (CheckWeatherType(currentDay) < 90 && current.lemonadePrice <= 35)
            {
                //1 in 4 buys if amount of lemons and sugar per pitch are within 3
                //improves to 1 in 2 buys if ice per cup is with in 2 of ten total
                //everyone buys if there is 8 lemons, 8 sugar, and 10 ice cubes
            }
            else if (CheckWeatherType(currentDay) > 89 && current.lemonadePrice <= 40)
            {
                //1 in 4 buys if amount of lemons and sugar per pitch are within 3
                //improves to 1 in 2 buys if ice per cup is with in 2 of ten total
                //everyone buys if there is 8 lemons, 8 sugar, and 10 ice cubes
            }
            else
            {
                //without right price for tempurature only 1 in 20
                //improves to 1 in 12 buys if ice per cup is within 2 of ten total
                //1 in 10 buys if there is 8 lemons, 8 sugar, and 10 ice cubes
            }
        }
        public int CheckWeatherType(Weather currentDay)
        {
            switch (currentDay.weatherType)
            {
                case "sunny":
                    return currentDay.temperature;
                case "rainy":
                    return currentDay.temperature - 10;
                default:
                    return currentDay.temperature - 5;
            }
        }
    }
}
