using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    internal class program
    {
        static void Main(string[] args)
        {
            string newTelephone;
            float price = 0.0f;
            int amount = 0;
            float BTW = 1.09f;
            Telephone Telephone1 = new Telephone("iPhone", "iPhone XS", "Apple IOS", "Steve Jobs", 249.0f);
            Telephone Telephone2 = new Telephone("Samsung", "Galaxy S7", "Android", "Kim Ki-Nam", 370.0f);
            Telephone Telephone3 = new Telephone("Google Pixel", "Pixel 3", "Chrome OS", "Sundar Pichai", 217.99f);

            Console.WriteLine("welke telefoon wil je kopen (gratis verzending vanaf €400? opties: ");
            Console.WriteLine("optie 1 | merk: " + Telephone1.type + ", model: " + Telephone1.model + ", OS: " + Telephone1.OS + ", CEO: " + Telephone1.CEO + ", prijs: " + Telephone1.price);
            Console.WriteLine("optie 2 | merk: " + Telephone2.type + ", model: " + Telephone2.model + ", OS: " + Telephone2.OS + ", CEO: " + Telephone2.CEO + ", prijs: " + Telephone2.price);
            Console.WriteLine("optie 3 | merk: " + Telephone3.type + ", model: " + Telephone3.model + ", OS: " + Telephone3.OS + ", CEO: " + Telephone3.CEO + ", prijs: " + Telephone3.price);

            newTelephone = Console.ReadLine().ToLower();
            if (newTelephone == Telephone1.model.ToLower()){
                price = Telephone1.price;
            } else if (newTelephone == Telephone2.model.ToLower()){
                price = Telephone2.price;
            } else if (newTelephone == Telephone3.model.ToLower()){
                price = Telephone3.price;
            }
            Console.WriteLine("hoe veel wil je?");
            amount = int.Parse(Console.ReadLine());
            price = price * amount * BTW;
            if (price < 400.0f)
            {
                price += 20;
                Console.WriteLine("€20 verzendkosten");
            }

            Console.WriteLine("prijs invlusief BTW: " + price);

            Console.ReadLine();
        }
    }
}
