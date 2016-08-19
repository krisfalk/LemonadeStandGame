using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStandGame
{
    class FileWriter
    {
        public FileWriter(Inventory currentInventory, Day currentDay, Popularity popularity, Player player1, Weather currentWeather, Weather tomorrowsWeather)
        {
            TextWriter saveGame = new StreamWriter(".\\savedGame.txt");

            saveGame.WriteLine("Name: Money: Money Spent: Total Income:");
            saveGame.WriteLine(player1.name);
            saveGame.WriteLine(player1.money);
            saveGame.WriteLine(player1.moneySpent);
            saveGame.WriteLine(player1.totalIncome);
            saveGame.WriteLine("Inventory in this order: Cups: Lemons: Sugar:");
            saveGame.WriteLine(currentInventory.numCups);
            saveGame.WriteLine(currentInventory.numLemons);
            saveGame.WriteLine(currentInventory.numSugar);
            saveGame.WriteLine("Current Weather: Type: Tempurature:");
            saveGame.WriteLine(currentWeather.weatherType);
            saveGame.WriteLine(currentWeather.temperature);
            saveGame.WriteLine("Tomorrows forcast: Type: Degrees:");
            saveGame.WriteLine(tomorrowsWeather.weatherType);
            saveGame.WriteLine(tomorrowsWeather.temperature);
            saveGame.WriteLine("Popularity level:", popularity.popularityLevel);
            saveGame.WriteLine(popularity.popularityLevel);
            saveGame.WriteLine("You are on day number: out of:", currentDay.dayNum, currentDay.totalDays);
            saveGame.WriteLine(currentDay.dayNum);
            saveGame.WriteLine(currentDay.totalDays);

            saveGame.Close();
            Environment.Exit(0);
        }
    }
}
