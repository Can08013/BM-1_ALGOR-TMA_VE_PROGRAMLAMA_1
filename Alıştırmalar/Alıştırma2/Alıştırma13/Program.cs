using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Tam Sayı Giriniz...");
            int tmsy = int.Parse(Console.ReadLine());

            int toplamsy = 0;
            int maxk = tmsy;

            // Sondan 3. sayıyı takip etmek için 3 değişken
            int oncekindenOnceki = -1;
            int onceki = -1;
            int son = tmsy;

            while (son != 1)
            {
                // Değerleri kaydır
                oncekindenOnceki = onceki;
                onceki = son;

                // Collatz adımı
                if (son % 2 == 0)
                    son = son / 2;
                else
                    son = son * 3 + 1;

                if (son > maxk)
                    maxk = son;

                toplamsy++;
            }

            Console.WriteLine("Toplam Adım Sayısı: " + toplamsy);
            Console.WriteLine("Ulaşılan En Büyük Değer: " + maxk);
            Console.WriteLine("1'e Ulaşmadan Önceki 3. Sayı: " + oncekindenOnceki);
        }
    }
}
