﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        Player player1;
        Day currentDay;
        Inventory currentInventory;
        Weather currentWeather;
        Weather tomorrowsWeather;
        Store myStore;
        Customer[] customers;
        Popularity popularity;
        int cupsPurchased;
        public Game()
        {
            Console.WriteLine("Welcome to Kris' Lemonade Stand Game!!\nWhat is your name?");
            player1 = new Player(Console.ReadLine());
            Console.WriteLine("{0} has ${1}", player1.name, player1.money);
            currentDay = new Day();
            currentInventory = new Inventory();
            currentWeather = new Weather();
            myStore = new Store();
            popularity = new Popularity();
            
            
        }
        public void RunGame()
        {
            for (int i = 0; i < currentDay.totalDays; i++)
            {
                customers = new Customer[popularity.BonusCustomers()];
                Console.Clear();
                currentDay.dayNum++;
                Thread.Sleep(500);
                tomorrowsWeather = new Weather();
                PrintWeather();
                SetInventory();
                SetCustomerBase();
                player1.SetRecipe();
                PrintWeather();
                myStore.SetSellPrice();
                RunDay();
                popularity.AddToPopularity(cupsPurchased);
                Console.ReadLine();
                currentWeather = tomorrowsWeather;
            }
        }
        public void SetInventory()
        {
            currentInventory.numIce = 0;
            PrintAll();
            int cups = myStore.BuyCups(player1.money);
            player1.money = player1.money - cups * .03;
            currentInventory.numCups = currentInventory.numCups + cups;
            Console.Clear();
            PrintAll();
            int lemons = myStore.BuyLemons(player1.money);
            player1.money = player1.money - lemons * .06;
            currentInventory.numLemons = currentInventory.numLemons + lemons;
            Console.Clear();
            PrintAll();
            int sugar = myStore.BuySugar(player1.money);
            player1.money = player1.money - sugar * .06;
            currentInventory.numSugar = currentInventory.numSugar + sugar;
            Console.Clear();
            PrintAll();
            Console.WriteLine("All ice has melted.");
            currentInventory.numIce = 0;
            currentInventory.numIce = myStore.BuyIce(player1.money);
            player1.money = player1.money - currentInventory.numIce * .006;
            Console.Clear();
        }
        public void SetCustomerBase()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Customer(i);
            }
        }
        public void RunDay()
        {
            cupsPurchased = 0;
            for (int i = 0; i < customers.Length; i += 0)
            {
                
                SetPitcher();
                if (currentInventory.pitcher != 0 && currentInventory.numCups - 15 > 0 && currentInventory.numIce - 15 * player1.iceRecipe > 0)
                {
                    while (currentInventory.pitcher > 0 && i < customers.Length)
                    {
                        if (customers[i].ToBuyOrNot(myStore, currentWeather, player1))
                        {
                            cupsPurchased++;
                            currentInventory.pitcher--;
                            currentInventory.numIce -= player1.iceRecipe;
                            currentInventory.numCups--;
                            Console.WriteLine("Customer {0} buys a cup of lemonade.", i + 1);
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Customer {0} passes by without buying.", i + 1);
                            i++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("SOLD OUT");
                    i++;
                }
            }
            double dailyEarnings = cupsPurchased * myStore.lemonadePrice;
            player1.money += dailyEarnings;
            PrintAll();
            Console.WriteLine("You sold {0} number of cups today and made ${1}.", cupsPurchased, dailyEarnings);
        }
        public void SetPitcher()
        {
            if(currentInventory.numLemons - player1.lemonRecipe >= 0 && currentInventory.numSugar - player1.sugarRecipe >= 0)
            {
                    currentInventory.numLemons -= player1.lemonRecipe;
                    currentInventory.numSugar -= player1.sugarRecipe;
                    currentInventory.pitcher = 15;
            }
            else
            {
                currentInventory.pitcher = 0;
            }
        }
        public void PrintAll()
        {
            Console.WriteLine("Current Inventory:\nCups: {0}\nLemons: {1}\nCups of Sugar: {2}\nIce Cubes: {3}", currentInventory.numCups, currentInventory.numLemons, currentInventory.numSugar, currentInventory.numIce);
        }
        public void PrintWeather()
        {
            Console.WriteLine("Day number {0} of {1}.\nToday's weather is {2} and {3} degrees.\nTomorrow's forcast is {4} and {5} degrees.", currentDay.dayNum, currentDay.totalDays, currentWeather.weatherType, currentWeather.temperature, tomorrowsWeather.weatherType, tomorrowsWeather.temperature);
        }
    }
}
