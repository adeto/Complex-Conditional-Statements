using System;

namespace _04.Fruit_Of_Vegetables
{
    class FrOrVeg
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();

            if (text == "banana" || text == "apple" || text == "kiwi" || text == "cherry" || text == "lemon" || text == "grapes")
            {

                Console.WriteLine("fruit");
            }

        
            else if (text == "tomato" || text == "cucumber" || text == "pepper" || text == "carrot")
            {
                Console.WriteLine("vegetable");
            
           }
           
                else 
            { 
                Console.WriteLine("unknown");
            }
        }

    }
}
