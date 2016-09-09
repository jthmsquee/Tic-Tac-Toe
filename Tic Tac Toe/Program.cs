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
            OneThruNine = new int[9];
            int X = 1;
            int O = 2;
            printBoard();
            Console.WriteLine("Player 1 where do you want to put your X?");
            int input = inputTextHandler();
            while (input == -1)
            {
                input = inputTextHandler();
            }
            WhereTheXOrOAre(input, X);
            printBoard();
            Console.WriteLine("Player 2 where do you want to put your O?");
            Console.ReadLine();

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
                if (OneThruNine[inputText - 1] >= 1)
                {
                    throw new Exception();
                }
                return inputText;
            }
            catch
            {
                Console.WriteLine("Invalid option try again");
            }
            return -1;
        }

        private static void WhereTheXOrOAre(int PlayersInput, int isThisAnXOrAnO)
        {
            OneThruNine[PlayersInput - 1] = isThisAnXOrAnO;
        }

        private static void printBoard()
        {
            Console.WriteLine(whichIsIt(OneThruNine[0]) + "|" + whichIsIt(OneThruNine[1]) + "|" + whichIsIt(OneThruNine[2]));
            Console.WriteLine("------");
            Console.WriteLine(whichIsIt(OneThruNine[3]) + "|" + whichIsIt(OneThruNine[4]) + "|" + whichIsIt(OneThruNine[5]));
            Console.WriteLine("------");
            Console.WriteLine(whichIsIt(OneThruNine[6]) + "|" + whichIsIt(OneThruNine[7]) + "|" + whichIsIt(OneThruNine[8]));
        }

        private static string whichIsIt(int whatever)
        {
            if (whatever == 0)
            {
                return " ";
            }
            if (whatever == 1)
            {
                return "X";
            }
            if (whatever == 2)
            {
                return "O";
            }
            return "-1";
        }
    }
}
