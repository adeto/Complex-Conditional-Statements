using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Vacantion
{
    static void Main(string[] args)
    {
        //input
        var adults = int.Parse(Console.ReadLine());
        var kids = int.Parse(Console.ReadLine());
        var nights = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine();

        //variables
        double priceAdults = 1.0;
        double priceKids = 1.0;
        double expenseTransport;
        double hotel;
        double comision;
        double totalSum;


        //actions
        if (transport == "train")
        {
            priceAdults = 24.99;
            priceKids = 14.99;
            if (adults + kids >= 50)
            {
                priceAdults = priceAdults / 2;
                priceKids = priceKids / 2;

            }
            
        }
        else if (transport == "bus")
        {
            priceAdults = 32.50;
            priceKids = 28.50;
        }
        else if (transport == "boat")
        {
            priceAdults = 42.99;
            priceKids = 39.99;
        }
        else if (transport == "airplane")
        {
            priceAdults = 70.00;
            priceKids = 50.00;
        }
        //Console.WriteLine("=================================");
        //Console.WriteLine(priceAdults);
        //Console.WriteLine(priceKids);

        expenseTransport = ((adults * priceAdults) + (kids * priceKids)) * 2;
        //Console.WriteLine(expenseTransport);
        hotel = nights * 82.99;
        //Console.WriteLine(hotel);
        comision = (expenseTransport + hotel) * 0.10;
        //Console.WriteLine(comision);
        totalSum = expenseTransport + hotel + comision;
        Console.WriteLine("{0:f2}", totalSum);

    }
}

