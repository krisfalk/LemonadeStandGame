using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer startGame = new SoundPlayer("http://themushroomkingdom.net/sounds/wav/sm3dl/sm3dl_luigi_lets-a_go.wav");
            Player player1 = new Player("");
            Player player2 = new Player("");

            startGame.Play();
            Console.WriteLine("Let's Go!");
            Game game = new Game(1);
            game.RunGame();
            player1 = game.EndGame();
            Console.WriteLine("Does player 2 want to try and beat your score?");
            if (Console.ReadLine() == "yes")
            {
                Game game2 = new Game(1);
                game2.RunGame();
                player2 = game2.EndGame();
                Console.Clear();
                Console.WriteLine("{0}, your final total:\nTotal Income: {1}\nTotal Expenses: {2}\nLiquidated Inventory Value: {3}\nNet Profit/Loss: {4:0.00}\n\n", player1.name, player1.totalIncome, player1.moneySpent, player1.liquidate, player1.profitLoss);
                Console.WriteLine("{0}, your final total:\nTotal Income: {1}\nTotal Expenses: {2}\nLiquidated Inventory Value: {3}\nNet Profit/Loss: {4:0.00}", player2.name, player2.totalIncome, player2.moneySpent, player2.liquidate, player2.profitLoss);
                Console.ReadLine();
            }

        }
    }
}
