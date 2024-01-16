using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxchar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] tablicaLiter = { 'a', 'b', 'c', 'a', 'd', 'b', 'e', 'a', 'c', 'f' };
            char najczestrza = ZnajdzNajczestrza(tablicaLiter);
            Console.WriteLine($"Najczęściej powtarzająca się litera to: {najczestrza}");
            Console.ReadKey();

        }
        static char ZnajdzNajczestrza(char[] tablica)
        {
            int max = 0;
            char najczestrza = '\0';

            for (int i = 0; i < tablica.Length; i++)
            {
                char obecnaLitera = tablica[i];
                int obecnaLiteraIlosc = 0;

                for (int j = 0; j < tablica.Length; j++)
                {
                    if (tablica[j] == obecnaLitera)
                    {
                        obecnaLiteraIlosc++;
                    }
                }
                if (obecnaLiteraIlosc > max)
                {
                    max = obecnaLiteraIlosc;
                    najczestrza = obecnaLitera;
                }
            }
            return najczestrza;
        }
    }
}