using System;

namespace _05.Invalid_Number
{
    class InvalidNum
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var validNum = (num == 0 || (num >= 100 && num <= 200));

            if (!validNum)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
