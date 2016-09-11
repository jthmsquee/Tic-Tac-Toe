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

            while (whoIsWinning() == 0)
            {
                Console.WriteLine("Player 1 where do you want to put your X?");
                int input = inputTextHandler();

                while (input == -1)
                {
                    input = inputTextHandler();
                }
                WhereTheXOrOAre(input, X);
                printBoard();
                int fuckMyAss = whoIsWinning();
                if (fuckMyAss == 1 || fuckMyAss == -1)
                {
                    break;
                }
                Console.WriteLine("Player 2 where do you want to put your O?");
                input = inputTextHandler();

                while (input == -1)
                {
                    input = inputTextHandler();
                }
                WhereTheXOrOAre(input, O);
                printBoard();
            }
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
                if (OneThruNine[inputText - 1] == 1 || OneThruNine[inputText -1] == 2)
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
        private static int whoIsWinning()
        {
            if (OneThruNine[0] == OneThruNine[1] && OneThruNine[0] == OneThruNine[2])
            {
                if (OneThruNine[0] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[0]) + " YOU HAVE WON");
                    return OneThruNine[0];
                }

            }
            if (OneThruNine[3] == OneThruNine[4] && OneThruNine[3] == OneThruNine[5])
            {
                if (OneThruNine[3] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[3]) + " YOU HAVE WON");
                    return OneThruNine[3];
                }

            }
            if (OneThruNine[6] == OneThruNine[7] && OneThruNine[6] == OneThruNine[8])
            {
                if (OneThruNine[6] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[6]) + " YOU HAVE WON");
                    return OneThruNine[6];
                }

            }
            if (OneThruNine[0] == OneThruNine[3] && OneThruNine[0] == OneThruNine[6])
            {
                if (OneThruNine[0] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[0]) + " YOU HAVE WON");
                    return OneThruNine[0];
                }

            }
            if (OneThruNine[1] == OneThruNine[4] && OneThruNine[1] == OneThruNine[7])
            {
                if (OneThruNine[1] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[1]) + " YOU HAVE WON");
                    return OneThruNine[1];
                }

            }
            if (OneThruNine[2] == OneThruNine[5] && OneThruNine[2] == OneThruNine[8])
            {
                if (OneThruNine[2] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[2]) + " YOU HAVE WON");
                    return OneThruNine[2];
                }

            }
            if (OneThruNine[0] == OneThruNine[4] && OneThruNine[0] == OneThruNine[8])
            {
                if (OneThruNine[0] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[0]) + " YOU HAVE WON");
                    return OneThruNine[0];
                }

            }
            if (OneThruNine[2] == OneThruNine[4] && OneThruNine[2] == OneThruNine[6])
            {
                if (OneThruNine[2] != 0)
                {
                    Console.WriteLine("CONGRATULATIONS PLAYER " + whichIsIt(OneThruNine[2]) + " YOU HAVE WON");
                    return OneThruNine[2];
                }

            }
            if (!OneThruNine.Contains(0))
            {
                Console.WriteLine("Cats Game");
                return -1;
            }
            return 0; 
        }
    }
}
