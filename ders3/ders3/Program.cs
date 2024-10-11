using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iki tane int değer belirle ve ternary operatörü ile büyük olanı bul
            int deger1 = 123;
            int deger2 = 124;
            bool sonuc = deger2 > deger1;
            if (sonuc== true )
            {
                Console.WriteLine("Büyük olan değer : " + deger2);
            }
            else
            {
                Console.WriteLine("Büyük olan değer : " + deger1);
            }
            Console.Read();
        }
    }
}
