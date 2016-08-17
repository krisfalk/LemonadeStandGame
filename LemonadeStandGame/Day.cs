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
        }
        public int CountDaysLeft()
        {
            return totalDays - dayNum;
        }
    }
}
