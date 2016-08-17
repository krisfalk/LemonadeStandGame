using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Store
    {
        public double lemonadePrice;
        public Store()
        {

        }
        public void SetSellPrice()
        {
            Console.WriteLine("What would you like to set the price of lemonade at for today? \n(Price should be no lower than $0.20 and no higher than $1.00)");
            double answer = Convert.ToDouble(Console.ReadLine());
            if(answer >= .2 && answer <= 1.00)
            {
                lemonadePrice = answer;
            }
            else { SetSellPrice(); }
        }
        public int BuyCups(double totalMoney)
        {
            int totalCups = 0;
            bool buyingCups = true;
            double newMoneyTotal = totalMoney;
            while (buyingCups)
            {
                Console.WriteLine("You have ${0}.\nEnter how many Cups you want to buy? (0, 25 for $0.75, 50 for $1.50, 100 for $3.00)", newMoneyTotal);
                int buyCups = Convert.ToInt32(Console.ReadLine());
                switch (buyCups)
                {
                    case 0:
                        buyingCups = false;
                        break;
                    case 25:
                        if (newMoneyTotal > .75)
                        {
                            totalCups = totalCups + 25;
                            newMoneyTotal = newMoneyTotal - .75;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 50:
                        if (newMoneyTotal > 1.50)
                        {
                            totalCups = totalCups + 50;
                            newMoneyTotal = newMoneyTotal - 1.50;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 100:
                        if (newMoneyTotal > 3.00)
                        {
                            totalCups = totalCups + 100;
                            newMoneyTotal = newMoneyTotal - 3.00;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection, try again.");
                        break;
                }
            }
            return totalCups;
        }
        public int BuyLemons(double totalMoney)
        {
            int totalLemons = 0;
            bool buyingLemons = true;
            double newMoneyTotal = totalMoney;
            while (buyingLemons)
            {
                Console.WriteLine("You have ${0}.\nEnter how many Lemons do you want to buy? (0, 10 for $0.60, 30 for $1.80, 60 for $3.60)", newMoneyTotal);
                int buyLemons = Convert.ToInt32(Console.ReadLine());
                switch (buyLemons)
                {
                    case 0:
                        buyingLemons = false;
                        break;
                    case 10:
                        if(newMoneyTotal > .60)
                        {
                            totalLemons = totalLemons + 10;
                            newMoneyTotal = newMoneyTotal - .60;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 30:
                        if (newMoneyTotal > 1.80)
                        {
                            totalLemons = totalLemons + 30;
                            newMoneyTotal = newMoneyTotal - 1.80;

                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 60:
                        if (newMoneyTotal > 3.60)
                        {
                            totalLemons = totalLemons + 60;
                            newMoneyTotal = newMoneyTotal - 3.60;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection, try again.");
                        break;
                }
            }
            return totalLemons;
        }
        public int BuySugar(double totalMoney)
        {
            int totalSugar = 0;
            bool buyingSugar = true;
            double newMoneyTotal = totalMoney;
            while (buyingSugar)
            {
                Console.WriteLine("You have ${0}.\nEnter how many cups of sugar do you want to buy? (0, 10 for $0.60, 20 for $1.20, 40 for $2.40)", newMoneyTotal);
                int buySugar = Convert.ToInt32(Console.ReadLine());
                switch (buySugar)
                {
                    case 0:
                        buyingSugar = false;
                        break;
                    case 10:
                        if (newMoneyTotal > .60)
                        {
                            totalSugar = totalSugar + 10;
                            newMoneyTotal = newMoneyTotal - .60;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 20:
                        if (newMoneyTotal > 1.20)
                        {
                            totalSugar = totalSugar + 20;
                            newMoneyTotal = newMoneyTotal - 1.20;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 40:
                        if (newMoneyTotal > 2.40)
                        {
                            totalSugar = totalSugar + 40;
                            newMoneyTotal = newMoneyTotal - 2.40;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection, try again.");
                        break;
                }
            }
            return totalSugar;
        }
        public int BuyIce(double totalMoney)
        {
            int totalIce = 0;
            bool buyingIce = true;
            double newMoneyTotal = totalMoney;
            
            while (buyingIce)
            {
                Console.WriteLine("You have ${0}.\nEnter how many ice cubes do you want to buy? (0, 100 for $0.60, 250 for $1.50, 400 for $2.40)", newMoneyTotal);
                int buyIce = Convert.ToInt32(Console.ReadLine());
                switch (buyIce)
                {
                    case 0:
                        buyingIce = false;
                        break;
                    case 100:
                        if (newMoneyTotal > .60)
                        {
                            totalIce = totalIce + 100;
                            newMoneyTotal = newMoneyTotal - .60;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 250:
                        if (newMoneyTotal > 1.50)
                        {
                            totalIce = totalIce + 250;
                            newMoneyTotal = newMoneyTotal - 1.50;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 400:
                        if (newMoneyTotal > 2.40)
                        {
                            totalIce = totalIce + 400;
                            newMoneyTotal = newMoneyTotal - 2.40;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection, try again.");
                        break;
                }
            }
            return totalIce;
        }
    }
}
