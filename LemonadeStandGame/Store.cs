using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Store
    {
        
        public Store()
        {

        }
        public int BuyCups(double totalMoney)
        {
            int totalCups = 0;
            bool buyingCups = true;
            double newMoneyTotal = totalMoney;
            while (buyingCups)
            {
                Console.WriteLine("You have ${0}.\nEnter how many Cups you want to buy? (0, 25 for $1.00, 50 for $2.00, 100 for $4.00)", newMoneyTotal);
                int buyCups = Convert.ToInt32(Console.ReadLine());
                switch (buyCups)
                {
                    case 0:
                        buyingCups = false;
                        break;
                    case 25:
                        if (newMoneyTotal > 1.00)
                        {
                            totalCups = totalCups + 25;
                            newMoneyTotal = newMoneyTotal - 1.00;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 50:
                        if (newMoneyTotal > 2.00)
                        {
                            totalCups = totalCups + 50;
                            newMoneyTotal = newMoneyTotal - 2.00;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 100:
                        if (newMoneyTotal > 4.00)
                        {
                            totalCups = totalCups + 100;
                            newMoneyTotal = newMoneyTotal - 4.00;
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
                Console.WriteLine("You have ${0}.\nEnter how many Lemons do you want to buy? (0, 10 for $0.70, 30 for $2.10, 60 for $4.20)", newMoneyTotal);
                int buyLemons = Convert.ToInt32(Console.ReadLine());
                switch (buyLemons)
                {
                    case 0:
                        buyingLemons = false;
                        break;
                    case 10:
                        if(newMoneyTotal > .70)
                        {
                            totalLemons = totalLemons + 25;
                            newMoneyTotal = newMoneyTotal - .70;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 30:
                        if (newMoneyTotal > 2.10)
                        {
                            totalLemons = totalLemons + 30;
                            newMoneyTotal = newMoneyTotal - 2.10;

                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 60:
                        if (newMoneyTotal > 4.20)
                        {
                            totalLemons = totalLemons + 60;
                            newMoneyTotal = newMoneyTotal - 4.20;
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
                Console.WriteLine("You have ${0}.\nEnter how many cups of sugar do you want to buy? (0, 10 for $0.70, 20 for $1.40, 40 for $2.80)", newMoneyTotal);
                int buySugar = Convert.ToInt32(Console.ReadLine());
                switch (buySugar)
                {
                    case 0:
                        buyingSugar = false;
                        break;
                    case 10:
                        if (newMoneyTotal > .70)
                        {
                            totalSugar = totalSugar + 25;
                            newMoneyTotal = newMoneyTotal - .70;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 20:
                        if (newMoneyTotal > 1.40)
                        {
                            totalSugar = totalSugar + 20;
                            newMoneyTotal = newMoneyTotal - 1.40;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 40:
                        if (newMoneyTotal > 2.12)
                        {
                            totalSugar = totalSugar + 40;
                            newMoneyTotal = newMoneyTotal - 2.80;
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
                Console.WriteLine("You have ${0}.\nEnter how many ice cubes do you want to buy? (0, 100 for $0.80, 250 for $2.00, 400 for $3.28)", newMoneyTotal);
                int buyIce = Convert.ToInt32(Console.ReadLine());
                switch (buyIce)
                {
                    case 0:
                        buyingIce = false;
                        break;
                    case 100:
                        if (newMoneyTotal > .80)
                        {
                            totalIce = totalIce + 100;
                            newMoneyTotal = newMoneyTotal - .80;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 250:
                        if (newMoneyTotal > 2.00)
                        {
                            totalIce = totalIce + 250;
                            newMoneyTotal = newMoneyTotal - 2.00;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money, try again.");
                        }
                        break;
                    case 400:
                        if (newMoneyTotal > 3.20)
                        {
                            totalIce = totalIce + 400;
                            newMoneyTotal = newMoneyTotal - 3.20;
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
