using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        Player player1;
        Day currentDay;
        Inventory currentInventory;
        Weather currentWeather;
        Store myStore;
        Customer[] customers = new Customer[100];
        public Game()
        {
            Console.WriteLine("Welcome to Kris' Lemonade Stand Game!!\nWhat is your name?");
            player1 = new Player(Console.ReadLine());
            Console.WriteLine("{0}'s has ${1}", player1.name, player1.money);
            currentDay = new Day();
            currentInventory = new Inventory();
            currentWeather = new Weather();
            myStore = new Store();
        }
        public void RunGame()
        {
            for (int i = 0; i < currentDay.totalDays; i++)
            {
                Console.Clear();
                currentDay.dayNum++;
                currentWeather.ChangeWeather();
                Console.WriteLine("Day number {0} of {1}.\nToday's weather is {2} and {3} degrees.", currentDay.dayNum, currentDay.totalDays, currentWeather.weatherType, currentWeather.temperature);
                SetInventory();
                SetCustomerBase();
                player1.SetSellPrice();
                RunDay();
            }
        }
        public void SetInventory()
        {
            currentInventory.numIce = 0;
            Console.WriteLine("Current Inventory:\nCups: {0}\nLemons: {1}\nCups of Sugar: {2}\nIce Cubes: {3}", currentInventory.numCups, currentInventory.numLemons, currentInventory.numSugar, currentInventory.numIce);

            int cups = myStore.BuyCups(player1.money);
            player1.money = player1.money - cups * .04;
            currentInventory.numCups = currentInventory.numCups + cups;
            int lemons = myStore.BuyLemons(player1.money);
            player1.money = player1.money - lemons * .07;
            currentInventory.numLemons = currentInventory.numLemons + lemons;
            int sugar = myStore.BuySugar(player1.money);
            player1.money = player1.money - currentInventory.numSugar * .07;
            currentInventory.numSugar = currentInventory.numSugar + sugar;
            Console.WriteLine("All ice has melted.");
            currentInventory.numIce = myStore.BuyIce(player1.money);
            player1.money = player1.money - currentInventory.numIce * .008;
        }
        public void SetCustomerBase()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                Random random = new Random();
                int getCustomer = random.Next(1, 6);
                switch (getCustomer)
                {
                    case 1:
                        customers[i] = new KidCustomer();
                        break;
                    case 2:
                        customers[i] = new AdultCustomer();
                        break;
                    case 3:
                        customers[i] = new GrandmaCustomer();
                        break;
                    case 4:
                        customers[i] = new MascotCustomer();
                        break;
                    default:
                        customers[i] = new AthleteCustomer();
                        break;
                }

            }
        }
        public void RunDay()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i].ToBuyOrNot(currentInventory, currentWeather);
            }
        }
    }
}
