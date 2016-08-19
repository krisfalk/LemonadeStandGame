using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class FileReader
    {
        private int cups;
        private int currentTemperature;
        private int dayNumber;
        private int lemons;
        private double money;
        private double moneySpent;
        private int popularityLevel;
        private int sugar;
        private int tomorrowTemperature;
        private int totalDays;
        private double totalIncome;

        public FileReader()
        {
            // create reader & open file
            TextReader readSave = new StreamReader(".\\savedGame.txt");
            // read lines of text
            string blank = readSave.ReadLine();
            string name = readSave.ReadLine();
            string money1 = readSave.ReadLine();
            double.TryParse(money1, out money);
            string moneySpent1 = readSave.ReadLine();
            double.TryParse(money1, out moneySpent);
            string totalIncome1 = readSave.ReadLine();
            double.TryParse(money1, out totalIncome);
            blank = readSave.ReadLine();
            string cups1 = readSave.ReadLine();
            int.TryParse(cups1, out cups);
            string lemons1 = readSave.ReadLine();
            int.TryParse(lemons1, out lemons);
            string sugar1 = readSave.ReadLine();
            int.TryParse(sugar1, out sugar);
            blank = readSave.ReadLine();
            string currentWeatherType = readSave.ReadLine();
            string currentTemperature1 = readSave.ReadLine();
            int.TryParse(currentTemperature1, out currentTemperature);
            blank = readSave.ReadLine();
            string tomorrowWeatherType = readSave.ReadLine();
            string tomorrowTemperature1 = readSave.ReadLine();
            int.TryParse(tomorrowTemperature1, out tomorrowTemperature);
            blank = readSave.ReadLine();
            string popularityLevel1 = readSave.ReadLine();
            int.TryParse(popularityLevel1, out popularityLevel);
            blank = readSave.ReadLine();
            string dayNumber1 = readSave.ReadLine();
            int.TryParse(dayNumber1, out dayNumber);
            string totalDays1 = readSave.ReadLine();
            int.TryParse(totalDays1, out totalDays);
            readSave.Close();
            File.Delete(".\\savedGame.txt");
            Game game = new Game(0);
            game.ResumeGame(name, money, totalIncome, moneySpent, cups, lemons, sugar, currentWeatherType, currentTemperature, tomorrowWeatherType, tomorrowTemperature, dayNumber, totalDays, popularityLevel);
        }
    }
}
