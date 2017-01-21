using System;

namespace _01._01.Triangle_Area
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine()); 
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
         
                double A = (x1 - x2) * (y1 + y2);
                double B = (x2 - x3) * (y2 += y3);
                double C = (x3 - x1) * (y3 + y1);


            double S = 0.5 * (A + B + C);

            Console.WriteLine(S);
            


        }
    }
}
