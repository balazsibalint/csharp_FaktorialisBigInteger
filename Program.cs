// BigInteger osztály (struktúra) elérése
// 1. System.Numerics névétr hozzáadása a referenciákhoz
// 2. using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;  

namespace FaktoriálisBigInteger
{
    class Program   
    {
        static void Main()
        {
            Console.WriteLine("Fakroeiális meghatározása 20 - 40 között");
            for (int szám = 20; szám <= 40; szám++)
            {
                BigInteger faktor = 1;
                for (int i = 2; i <= szám; i++)
                {   
                    faktor = faktor * i;
                }
                Console.WriteLine($"{szám}!= {faktor}");
            }

            Console.ReadKey();
        }
    }
}
