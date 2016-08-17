using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Customer
    {
        public int customerNumber;
        public Customer(int number)
        {
            customerNumber = number;
        }
        public bool ToBuyOrNot(Store current, Weather currentDay, Player player1)
        {
            Thread.Sleep((int)TimeSpan.FromSeconds(.2).TotalMilliseconds);
            Random random = new Random();
            if(currentDay.CheckWeatherType() < 60 && current.lemonadePrice <= .30)
            {
                if(player1.lemonRecipe - player1.sugarRecipe <= 3 && player1.lemonRecipe - player1.sugarRecipe >= -3)
                {
                    if(player1.iceRecipe >= 8 && player1.iceRecipe <= 12)
                    {
                        if(player1.lemonRecipe == 8 && player1.sugarRecipe == 8 && player1.iceRecipe == 10)
                        {
                            return true;
                        }
                        else
                        {
                            if (random.Next(1, 4) == 1) { return true; } else { return false; }
                        }
                    }else if (random.Next(1, 5) == 1) { return true; } else { return false; }
                } else if (random.Next(1, 6) == 1) { return true; } else { return false; }
            }
            else if (currentDay.CheckWeatherType() < 70 && current.lemonadePrice <= .45)
            {
                {
                    if (player1.lemonRecipe - player1.sugarRecipe <= 3 && player1.lemonRecipe - player1.sugarRecipe >= -3)
                    {
                        if (player1.iceRecipe >= 8 && player1.iceRecipe <= 12)
                        {
                            if (player1.lemonRecipe == 8 && player1.sugarRecipe == 8 && player1.iceRecipe == 10)
                            {
                                return true;
                            }
                            else
                            {
                                if (random.Next(1, 4) == 1) { return true; } else { return false; }
                            }
                        }
                        else if (random.Next(1, 5) == 1) { return true; } else { return false; }
                    }
                    else if (random.Next(1, 6) == 1) { return true; } else { return false; }
                }
            }
            else if (currentDay.CheckWeatherType() < 80 && current.lemonadePrice <= .60)
            {
                {
                    if (player1.lemonRecipe - player1.sugarRecipe <= 3 && player1.lemonRecipe - player1.sugarRecipe >= -3)
                    {
                        if (player1.iceRecipe >= 8 && player1.iceRecipe <= 12)
                        {
                            if (player1.lemonRecipe == 8 && player1.sugarRecipe == 8 && player1.iceRecipe == 10)
                            {
                                return true;
                            }
                            else
                            {
                                if (random.Next(1, 4) == 1) { return true; } else { return false; }
                            }
                        }
                        else if (random.Next(1, 5) == 1) { return true; } else { return false; }
                    }
                    else if (random.Next(1, 6) == 1) { return true; } else { return false; }
                }
            }
            else if (currentDay.CheckWeatherType() < 90 && current.lemonadePrice <= .75)
            {
                {
                    if (player1.lemonRecipe - player1.sugarRecipe <= 3 && player1.lemonRecipe - player1.sugarRecipe >= -3)
                    {
                        if (player1.iceRecipe >= 8 && player1.iceRecipe <= 12)
                        {
                            if (player1.lemonRecipe == 8 && player1.sugarRecipe == 8 && player1.iceRecipe == 10)
                            {
                                return true;
                            }
                            else
                            {
                                if (random.Next(1, 4) == 1) { return true; } else { return false; }
                            }
                        }
                        else if (random.Next(1, 5) == 1) { return true; } else { return false; }
                    }
                    else if (random.Next(1, 6) == 1) { return true; } else { return false; }
                }
            }
            else if (currentDay.CheckWeatherType() > 89 && current.lemonadePrice <= .90)
            {
                {
                    if (player1.lemonRecipe - player1.sugarRecipe <= 3 && player1.lemonRecipe - player1.sugarRecipe >= -3)
                    {
                        if (player1.iceRecipe >= 8 && player1.iceRecipe <= 12)
                        {
                            if (player1.lemonRecipe == 8 && player1.sugarRecipe == 8 && player1.iceRecipe == 10)
                            {
                                return true;
                            }
                            else
                            {
                                if (random.Next(1, 4) == 1) { return true; } else { return false; }
                            }
                        }
                        else if (random.Next(1, 5) == 1) { return true; } else { return false; }
                    }
                    else if (random.Next(1, 6) == 1) { return true; } else { return false; }
                }
            }
            else
            {
                {
                    if (player1.lemonRecipe - player1.sugarRecipe <= 3 && player1.lemonRecipe - player1.sugarRecipe >= -3)
                    {
                        if (player1.iceRecipe >= 8 && player1.iceRecipe <= 12)
                        {
                            if (player1.lemonRecipe == 8 && player1.sugarRecipe == 8 && player1.iceRecipe == 10)
                            {
                                if(random.Next(1, 10) == 1) { return true; } else { return false; }
                            }
                            else
                            {
                                if (random.Next(1, 13) == 1) { return true; } else { return false; }
                            }
                        }
                        else if (random.Next(1, 16) == 1) { return true; } else { return false; }
                    }
                    else if (random.Next(1, 21) == 1) { return true; } else { return false; }
                }
                //without right price for tempurature only 1 in 20
                //improves to 1 in 12 buys if ice per cup is within 2 of ten total
                //1 in 10 buys if there is 8 lemons, 8 sugar, and 10 ice cubes
            }
        }
        
    }
}
