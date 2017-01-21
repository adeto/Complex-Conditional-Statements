using System;

namespace _10.Animal_Type
{
    class Animal
    {
        static void Main()
        {
            var text = Console.ReadLine();
            switch (text)
            {
                case "dog": Console.WriteLine("mammal");break;
                case "crocodile": Console.WriteLine("reptile");break;
                case "tortoise": Console.WriteLine("reptile");break;
                case "snake": Console.WriteLine("reptile");break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
