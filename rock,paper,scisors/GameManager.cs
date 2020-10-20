using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    class GameManager
    {
        public int Play()
        {
            Jucator alegere = new Jucator();

            Obtiune alegerePlayer1 = new Obtiune();
            Obtiune alegerePlayer2 = new Obtiune();

            HitPoint player1Hp = new HitPoint();
            HitPoint player2Hp = new HitPoint();

            //Points player1Points = new Points();
            //Points player2Points = new Points();

            int roundCounter = 0;
            while (player1Hp.GetInternalValue() > 0 && player2Hp.GetInternalValue() > 0)
            {
                roundCounter++;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"              Runda {roundCounter}");
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("");
                Console.WriteLine(" ->player1 alege optiunea: ");
                alegerePlayer1 = alegere.Alege();
                Console.WriteLine("");
                Console.WriteLine(" ->player2 alege optiunea: ");
                alegerePlayer2 = alegere.Alege();
                Console.WriteLine("");

                if (alegerePlayer1.CriticalStrength == alegerePlayer2 || alegerePlayer2.CriticalWeakness == alegerePlayer1)
                {
                    player2Hp.DecreaseLife(10);
                    Console.WriteLine("player2 -10HP");
                }
                if (alegerePlayer1.StrongAgainst == alegerePlayer2 || alegerePlayer2.WeakAgainst == alegerePlayer1)
                {
                    player2Hp.DecreaseLife(5);
                    Console.WriteLine("player2 -5HP");
                }
                if (alegerePlayer1.CriticalWeakness == alegerePlayer2 || alegerePlayer2.CriticalStrength == alegerePlayer1)
                {
                    player1Hp.DecreaseLife(10);
                    Console.WriteLine("player1 -10HP");
                }
                if (alegerePlayer1.WeakAgainst == alegerePlayer2 || alegerePlayer2.StrongAgainst == alegerePlayer1)
                {
                    player1Hp.DecreaseLife(5);
                    Console.WriteLine("player1 -5HP");
                }

                Console.WriteLine($"Player1 HP: {player1Hp.GetInternalValue()} / Player2 HP: {player2Hp.GetInternalValue()}");

            }
            if (player1Hp.GetInternalValue() < 1)
            {
                Console.WriteLine("WINNER of the round player2");
                //player2Points.AddPoints(player2Hp.GetInternalValue());
                //Console.WriteLine(player2Points.GetPuncte());
                return player2Hp.GetInternalValue()+1;
            }
            else
            {
                Console.WriteLine("WINNER of the round player1");
                //player1Points.AddPoints(player1Hp.GetInternalValue());
                //Console.WriteLine(player1Points.GetPuncte());
                return player1Hp.GetInternalValue();
            }
        }
    }
}
