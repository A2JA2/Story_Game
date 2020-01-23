using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("You're walking down a street.\nyou see a bear, do you run Y/N?\n");
            string D1 = Console.ReadLine();
            if(D1 == "Y")
                {
                Console.Write("You live another day!\n");
                Console.ReadKey();
            }
            else
            {
                Console.Write("You're are dead - Game Over");
                Console.ReadKey();
            }
            Console.Write("are you here? Y/N\n");
        }
        
    }
    
}
