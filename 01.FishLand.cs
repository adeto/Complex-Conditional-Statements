using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FishLand
{
    static void Main(string[] args)
    {
        //input
        var skumria = double.Parse(Console.ReadLine());
        var caca = double.Parse(Console.ReadLine());

        var PalamudKG = double.Parse(Console.ReadLine());
        var safridKG = double.Parse(Console.ReadLine());
        var MidiKG = double.Parse(Console.ReadLine());

        //variables
        double palamudPrice;
        double sumPalamud;
        double safridPrice;
        double sumSafrid;
        double sumMidi;
        double TotalSum;

        //action
        palamudPrice = skumria + skumria * 0.60;
        sumPalamud = PalamudKG * palamudPrice;
        //Console.WriteLine(sumPalamud);
        safridPrice = caca + caca * 0.80;
        sumSafrid = safridKG * safridPrice;
        //Console.WriteLine(sumSafrid);
        sumMidi = MidiKG * 7.50;
        //Console.WriteLine(sumMidi);
        TotalSum = sumPalamud + sumSafrid + sumMidi;
        Console.WriteLine("{0:f2}", TotalSum);


    }
}

