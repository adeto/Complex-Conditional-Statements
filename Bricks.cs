using System;

namespace _02.Bricks
{
    class Bricks
    {
        static void Main()
        {
            var x = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            double covarage = w * m;
            double course = (x / covarage);

            Console.WriteLine(Math.Ceiling(course));
            
            
        }
    }
}
