using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessGame
{
    internal class guessGame
    {
        static void Main(string[] args)
        {
            int guesses = 3;
            string guess = "";
            string secretWord = "geheim";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("raad het woord, je kan nog " + guesses + " keer raden");
                guess = Console.ReadLine();

                if (guess == secretWord)
                {
                    Console.WriteLine("goed geraden");
                    break;
                }

                Console.WriteLine("tip: de eerste " + (4-guesses) + " letter(s) is/zijn: " + secretWord.Substring(0, 4-guesses));
                guesses--;
            }

            Console.WriteLine("je hebt het woord geraden in " + (4-guesses) + " beurten");
            Console.ReadLine();
        }
    }
}
