using System;

namespace _12.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            decimal costPr = 12.00m;
            decimal costNorm = 7.50m;
            decimal costDisc = 5.00m;
            decimal income;

            if (type == "Premiere")
            {
                income = rows * cols * costPr;
            }
            else if (type == "Normal")
            {
                income = rows * cols * costNorm;
            }
            else
            {
                income = rows * cols * costDisc;
            }
            Console.WriteLine("{0:f2}", income + " leva");
        }
    }
}
