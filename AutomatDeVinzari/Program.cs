using System;

namespace AutomatDeVinzari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acesta est un automat de vinzari!\n" +
                "Produsul are o valoare de 20 de centi!\n" +
               "Ce tip de monede doriti sa introduceti? N(nickel),D(dime) sau Q(quarter)?");
            char moneda = char.Parse(Console.ReadLine());
            int centi1 = 0;
            int centi2 = 0;
            switch (moneda)
            {
                case 'N':
                    centi2 = 5;
                    break;
                case 'D':
                    centi2 = 10;
                    break;
                case 'Q':
                    centi2 = 15;
                    break;
            }
            centi1 = centi1 + centi2;

            while (centi1 < 20)
            {
                Console.WriteLine($"Credit insuficient de {centi1} centi .Mai introduceti monede:");
                 moneda = char.Parse(Console.ReadLine());
                switch (moneda)
                {
                    case 'N':
                        centi2 = 5;
                        break;
                    case 'D':
                        centi2 = 10;
                        break;
                    case 'Q':
                        centi2 = 15;
                        break;
                }
                centi1 = centi1 + centi2;
            }
            if (centi1 >= 20)
            {
                int rest = centi1 - 20;
                Console.WriteLine($"Sold suficient de {centi1}\n" +
                    $"Restul dumneavoastra este {rest} centi");
            }
        }
        
        
    }
}
