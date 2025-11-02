using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma17
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("İki basamaklı bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi < 10 || sayi > 99)
            {
                Console.WriteLine("Lütfen iki basamaklı bir sayı giriniz!");
                return;
            }

            int onlar = sayi / 10;      // İlk basamak
            int birler = sayi % 10;     // İkinci basamak

            int yeniSayi = birler * 10 + onlar;

            Console.WriteLine($"Basamakları değiştirilen sayı: {yeniSayi}");

            if (yeniSayi > sayi)
                Console.WriteLine("Yeni sayı orijinal sayıdan büyüktür.");
            else if (yeniSayi < sayi)
                Console.WriteLine("Yeni sayı orijinal sayıdan küçüktür.");
            else
                Console.WriteLine("Yeni sayı orijinal sayıya eşittir.");
        }
    }
}
