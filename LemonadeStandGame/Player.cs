using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Player
    {
        public string name;
        public double money;
        public Player(string Name)
        {
            this.name = Name;
            money = 20.00;
        }
        public void SetSellPrice()
        {
            Console.WriteLine("What would you like to set the price of lemonade at for today?");
            lemonadePrice = Convert.ToDouble(Console.ReadLine());
        }
    }
}
