using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EnByk = int.MinValue;
            int sıra = 0;
            for (int i = 1; i <=10; i++)
            {
                Console.Write($"{i}. Sayıyı Giriniz: ");
                int sayı = int.Parse(Console.ReadLine());
                if (EnByk < sayı)
                {
                    EnByk = sayı;
                    sıra = i;
                }

            }
            Console.WriteLine($"En Büyük Sayı {EnByk} Sayısıdır Ve {sıra}. Sırada Girilmiştir.");

        }
    }
}
