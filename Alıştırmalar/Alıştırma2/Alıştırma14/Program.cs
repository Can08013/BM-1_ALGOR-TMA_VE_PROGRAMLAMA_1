using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ort;
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. Notu Giriniz: " );
                int not = int.Parse( Console.ReadLine() );
                toplam += not;
               
               



            }
            ort = toplam / 10;
            Console.Write("Sınıf Ortalaması: " + ort);


        }
    }
}
