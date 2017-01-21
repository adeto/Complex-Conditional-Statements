using System;

namespace Small_Shop
{
    class Shop
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantaty = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                if (product == "coffee")
                    Console.WriteLine(quantaty * 0.50);
            }
            if (city == "sofia")

            {
                if (product == "water") Console.WriteLine(quantaty * 0.80);
            }

            if (city == "sofia")
            {
                if (product == "beer") Console.WriteLine(quantaty * 1.20);
            }
            if (city == "sofia")
            {
                if (product == "sweets") Console.WriteLine(quantaty * 1.45);
            }
            if (city == "sofia")
            {
                if (product == "peanuts") Console.WriteLine(quantaty * 1.60);
            }

            if (city == "plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(quantaty * 0.40);
            }
            if (city == "plovdiv")
            {
                if (product == "water") Console.WriteLine(quantaty * 0.70);
            }
            if (city == "plovdiv")
            {
                if (product == "beer") Console.WriteLine(quantaty * 1.15);
            }
            if (city == "plovdiv")
            {
                if (product == "sweets") Console.WriteLine(quantaty * 1.30);
            }
            if (city == "plovdiv")
            {
                if (product == "peanuts") Console.WriteLine(quantaty * 1.50);
            }

            if (city == "varna")
            {
                if (product == "coffee")
                    Console.WriteLine(quantaty * 0.45);
            }
            if (city == "varna")
            {
                if (product == "water") Console.WriteLine(quantaty * 0.70);
            }
            if (city == "varna")
            {
                if (product == "beer") Console.WriteLine(quantaty * 1.10);
            }
            if (city == "varna")
            {
                if (product == "sweets") Console.WriteLine(quantaty * 1.35);
            }
            if (city == "varna")
            {
                if (product == "peanuts") Console.WriteLine(quantaty * 1.55);
            }
        }
    }  
}
