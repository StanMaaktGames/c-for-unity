using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            float number1 = 0.0f;
            float number2 = 0.0f;
            float answer = 0.0f;
            string action = "";

            Console.WriteLine("twee getallen? ");
            number1 = float.Parse(Console.ReadLine());
            number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("+, -, * of /?");
            action = Console.ReadLine();

            if (action == "+")
            {
                answer = number1 + number2;
                Console.WriteLine(number1 + " + " + number2 + " = " + answer);
            }
            else if (action == "-")
            {
                answer = number1 - number2;
                Console.WriteLine(number1 + " - " + number2 + " = " + answer);
            }
            else if (action == "*")
            {
                answer = number1 * number2;
                Console.WriteLine(number1 + " * " + number2 + " = " + answer);
            }
            else if (action == "/")
            {
                if (number2 == 0.0f)
                {
                    Console.WriteLine("kan niet delen door 0");
                }
                else
                {
                    answer = number1 / number2;
                    Console.WriteLine(number1 + " / " + number2 + " = " + answer);
                }
            }
            else
            {
                Console.WriteLine("geen geldige invoer");
            }

            Console.ReadLine();
        }
    }
}
