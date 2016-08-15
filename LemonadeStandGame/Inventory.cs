using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Inventory
    {
        public int numLemons;
        public int numSugar;
        public int numIce;
        public int numCups;
        public double lemonadePrice;
        public Inventory()
        {
            lemonadePrice = 0;
            numLemons = 0;
            numSugar = 0;
            numIce = 0;
            numCups = 0;
            Console.WriteLine("Inventory:nCups: {0}\nLemons: {1}\nSugar: {2}\nIce: {3}", numCups, numLemons, numSugar, numIce);
        }
        public void SetSellPrice()
        {
            Console.WriteLine("What would you like to set the price of lemonade at for today?");
            lemonadePrice = Convert.ToDouble(Console.ReadLine());
        }


    }
}
