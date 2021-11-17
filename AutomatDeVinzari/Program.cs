using System;

namespace AutomatDeVinzari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acesta est un automat de vinzari!\n" +
                "Produsul are o valoare de 20 de centi!\n" +
               "Ce tip de monede doriti sa introduceti? De 1, 5, 10, 20, 50 centi?");
            int centi1 = int.Parse(Console.ReadLine());
            int centi2 = 0;
            while (centi1<20)
            {
                Console.WriteLine($"Sold introdus de {centi1} centi  insuficient!\n" +
                    $"Mai introduceti monede:");
                centi2 = int.Parse(Console.ReadLine());
                centi1 = centi1 + centi2;
            }
            if (centi1>=20)
            {
                int rest = centi1 - 20;
                Console.WriteLine($"Sold suficient de {centi1}\n" +
                    $"Restul dumneavoastra este {rest} centi");
            }
        }
        
        
    }
}
