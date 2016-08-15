using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        public int dayNum;
        public int totalDays;
        public Day()
        {
            dayNum = 0;
            Console.WriteLine("How many days do you want run your lemonade stand?");
            totalDays = Convert.ToInt32(Console.ReadLine());
        }
        public int CountDaysLeft()
        {
            return totalDays - dayNum;
        }
    }
}
