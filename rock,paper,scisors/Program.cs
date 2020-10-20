using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    class Program : GameManager
    {
        public static void Meci()
        {
            Jucator player1 = new Jucator();
            Jucator player2 = new Jucator();

            GameManager joc = new GameManager();

            int choice = 0;
            do
            {
                int check;
                check = joc.Play();

                if (check % 10 == 1 || check % 10 == 6)
                    player2.Puncte.AddPoints(check - 1);
                else player1.Puncte.AddPoints(check);

                Console.WriteLine("");
                Console.WriteLine($"Player1 Points: {player1.Puncte.GetPuncte()} / Player2 Points: {player2.Puncte.GetPuncte()}");
                Console.WriteLine("************************************");
                Console.WriteLine("Daca vrei sa mai joci, apasa tasta 1");
                choice = Int32.Parse(Console.ReadLine());
            }
            while (choice != 0);

            if (player2.Puncte.GetPuncte() > player1.Puncte.GetPuncte())
                Console.WriteLine("player2 a castigat jocul");
            else Console.WriteLine("player1 a castigat jocul");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Meci();
        }
    }
}
