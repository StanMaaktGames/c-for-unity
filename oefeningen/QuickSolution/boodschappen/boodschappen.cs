using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boodschappen
{
    internal class boodschappen
    {
        static void Main(string[] args)
        {
            string[] products = { "kaas", "brood", "melk", "appels", "sla" };
            float[] prices = { 2.0f, 1.0f, 1.5f, 0.75f, 1.0f };
            string productsString = "";
            string pricesString = "";
            string[] boodschappen = {"", "", ""};
            string newProduct;
            float priceExclBTW = 0.0f;
            int amount = 0;
            float BTW = 0.0f;
            float BTWpercentage = 9.0f;

            foreach (string item in products)
            {
                productsString += item + " ";
            }
            foreach (float item in prices)
            {
                pricesString += item + " ";
            }

            Console.WriteLine("products: " + productsString);
            Console.WriteLine("prices: " + pricesString);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("welk product wil je kopen?");
                newProduct = Console.ReadLine();
                
                if (Array.Exists(products, s => s == newProduct))
                {
                    Console.WriteLine("hoeveel " + newProduct + " wil je?");
                    amount = int.Parse(Console.ReadLine());

                    Console.WriteLine(amount + " " + newProduct + " toegevoegd aan boodschappen");
                    boodschappen[i] = newProduct;
                    priceExclBTW += prices[i] * amount;
                }
                else
                {
                    Console.WriteLine(newProduct + " is niet beschikbaar");
                    i--;
                }

                BTW = calculateBTW(priceExclBTW, BTWpercentage);
                Console.WriteLine("prijs (inclusief BTW): $" + (BTW + priceExclBTW));
                Console.WriteLine("BTW: $" + BTW);

            }

            Console.ReadLine();
        }

        public static float calculateBTW(float priceExclBTW, float BTWpercentage)
        {
            return priceExclBTW * BTWpercentage / 100;
        }
    }
}