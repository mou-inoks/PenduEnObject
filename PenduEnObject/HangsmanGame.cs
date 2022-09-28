using System;
using System.Collections.Generic;
using System.Text;

namespace PenduEnObject
{
    public class HangsmanGame
    {
        public void StartUp()
        {
            Console.WriteLine("Welcome To HangsMan Game ! ");
            Console.WriteLine("Click to continue..");
            Console.WriteLine("Please Chose your userName");
            Console.ReadLine();
            Console.Clear();
            string player1Name = "";
            string player2Name = "";

            Console.Write("Player 1 : ");
            player1Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Player 2 : ");
            player2Name = Console.ReadLine();
            Player player1 = new Player(player1Name);
            Player player2 = new Player(player2Name);

            Console.Clear();
            Console.WriteLine(player1.Name + " choisis un mot à caché");

            Console.WriteLine();
            
            Console.Write("Hiden Word : ");
            string hiddenWord = Console.ReadLine();
            Table table = new Table();

            var listHiddenWord = table.SetTable(hiddenWord);

            foreach (var items in listHiddenWord)
            {
                Console.WriteLine(items);
            }



        }
    }
}
