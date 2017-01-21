using System;
namespace _01.Personal_Titles
{
    class GenderAndAge
    {
        static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (age >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");

            }
            if (age >= 16 && gender == "f" )
            {
                Console.WriteLine("Ms.");
            }
            else if (age < 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age <16 && gender == "f")
            {
                Console.WriteLine("Miss");
            }
                
        }
    }
}
