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
        public double moneySpent;
        public double totalIncome;
        public double liquidate;
        public double profitLoss;
        public int lemonRecipe;
        public int sugarRecipe;
        public int iceRecipe;

        public Player(string Name)
        {
            liquidate = 0;
            profitLoss = 0;
            moneySpent = 0;
            totalIncome = 0;
            this.name = Name;
            money = 20.00;
        }
        public void SetRecipe()
        {
            Console.WriteLine("How many lemons for your pitcher?");
            lemonRecipe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cups of sugar for your pitcher?");
            sugarRecipe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many ice cubes for each cup?");
            iceRecipe = Convert.ToInt32(Console.ReadLine());
        }
    }
}
