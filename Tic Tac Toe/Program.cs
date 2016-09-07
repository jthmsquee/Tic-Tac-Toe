using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        private static int[] OneThruNine { get; set; } 
        static void Main(string[] args)
        {
            OneThruNine = new int[8];
            Console.WriteLine(" | |  ");
            Console.WriteLine("------");
            Console.WriteLine(" | |  ");
            Console.WriteLine("------");
            Console.WriteLine(" | |  ");

                Console.WriteLine("Player 1 where do you want to put your X?");
                WhereTheXOrOAre(inputTextHandler, );
                Console.WriteLine("Player 2 where would you like to play your O?");
                inputTextHandler();
        }

        private static int inputTextHandler()
        {
            try
            {
                int inputText = Convert.ToInt32(Console.ReadLine());
                if (inputText < 1 || inputText > 9)
                {
                    throw new Exception();
                }
                return inputText;
            }
            catch
            {
                Console.WriteLine("Invalid option try again");
            }
            return 0;
        }

        private static void WhereTheXOrOAre(int PlayersInput, int isThisAnXOrAnO)
        {
            OneThruNine[PlayersInput - 1] = isThisAnXOrAnO;
        }
    }
}
