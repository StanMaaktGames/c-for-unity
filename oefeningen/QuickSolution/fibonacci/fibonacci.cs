using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class fibonacci
    {
        static void Main(string[] args)
        {
            int length = 0;

            List<int> fibonacci = new List<int>();
            fibonacci.Add(1);
            fibonacci.Add(2);

            Console.WriteLine("hoe lang moet de fibonacci reeks zijn? minimaal 2");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length-2; i++)
            {
                fibonacci.Add(fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2]);
            }

            Console.WriteLine("fibonacci reeks:");
            foreach (int item in fibonacci)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
