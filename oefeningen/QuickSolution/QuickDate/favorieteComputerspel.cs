using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace favorieteComputerspel
{
    internal class favorieteComputerspel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is jouw favoriete computerspel?");
            string favGame = Console.ReadLine();
            Console.WriteLine("Jouw favoriete computerspel is: " + favGame);
            Console.ReadLine();
        }
    }
}