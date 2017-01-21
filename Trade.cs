using System;

namespace _08.Trade_Comissions
{
    class Trade
    {
        static void Main()
        {
            var city = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());
            var comission = -1.0;

            if (city == "sofia")
            {
                if (0 <= s && s <= 500) comission = 0.05;
                else if (500 < s && s <= 1000) comission = 0.07;
                else if (1000 < s && s <= 10000) comission = 0.08;
                else if (s > 10000) comission = 0.12;
            }
            if (city == "varna")
            {
                if (0 <= s && s <= 500) comission = 0.045;
                else if (500 < s && s <= 1000) comission = 0.075;
                else if (1000 < s && s <= 10000) comission = 0.10;
                else if (s > 10000) comission = 0.13;
            }
            if (city == "plovdiv")
            {
                if (0 <= s && s <= 500) comission = 0.055;
                else if (500 < s && s <= 1000) comission = 0.08;
                else if (1000 < s &&s <= 10000) comission = 0.12;
                else if (s > 10000) comission = 0.145;
            }
            if (comission >= 0)
            {
                Console.WriteLine("{0:f2}", comission * s);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
