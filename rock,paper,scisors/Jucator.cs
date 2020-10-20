using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class Jucator
    {
        public HitPoint HP;
        public Points Puncte=new Points();
        public string Nume;
        public string Parola;
        public string Email;
        
       
        public Obtiune Alege()
        {           
            Console.WriteLine("   1 : rock");
            Console.WriteLine("   2 : paper");
            Console.WriteLine("   3 : scissors");
            Console.WriteLine("   4 : lizard");
            Console.WriteLine("   5 : spock");

            int choice = Int32.Parse(Console.ReadLine());  
            
            switch (choice)
            {                  
                case 2:
                    Console.WriteLine("Ai ales optiunea paper");
                    //Console.ReadLine();
                    return Paper.Instance;
                break;
                case 3:
                    Console.WriteLine("Ai ales optiunea scissors");
                    // Console.ReadLine();
                    return Scissors.Instance;
                break;
                case 4:
                    Console.WriteLine("Ai ales optiunea lizard");
                    // Console.ReadLine();
                    return  Lizard.Instance;
                break;
                case 5:
                    Console.WriteLine("Ai ales optiunea spock");
                    // Console.ReadLine();
                    return Spock.Instance;
                break;
                default:
                    Console.WriteLine("Ai ales optiunea rock");                 
                    //Console.ReadLine();
                    return Rock.Instance;
                break;                   
            }      
        }  
    }
}
