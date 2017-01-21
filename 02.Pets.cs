using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pets
{
    static void Main(string[] args)
    {
        //input
        var days = int.Parse(Console.ReadLine());
        var currentKGs = int.Parse(Console.ReadLine());
        var foodDog = float.Parse(Console.ReadLine());
        var foodCat = float.Parse(Console.ReadLine());
        var foodTurtle = float.Parse(Console.ReadLine());

        //variables
        float needFoodDog;
        float needFoodCat;
        float needFoodTurtle;
        float TotalKGsNeeded;
        float KGsLeft;
        float EndNeeded;

        //action
        needFoodDog = days * foodDog;
        needFoodCat = days * foodCat;
        needFoodTurtle = days * (foodTurtle/1000);
        TotalKGsNeeded = needFoodDog + needFoodCat + needFoodTurtle;

        if (TotalKGsNeeded <= currentKGs)
        {
            KGsLeft = currentKGs - TotalKGsNeeded;
            Console.WriteLine("{0} kilos of food left.", Math.Floor(KGsLeft));
        }
        else
        {
            EndNeeded = TotalKGsNeeded - currentKGs;
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(EndNeeded));
        }

    }
}

