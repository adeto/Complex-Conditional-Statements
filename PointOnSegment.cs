using System;


namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main()
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());


            if (point <= first && point >= second)
            {
                
                Console.Write("in ");
                var inResult = (point - second);
                Console.WriteLine(Math.Abs(inResult));
            }
            else
            {
                Console.Write("out ");
                var outResult = (first - point);
                Console.WriteLine(Math.Abs(outResult));
                ;
            }
      
        }
    }
}
