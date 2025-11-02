using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma12
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

           
            sayi = Math.Abs(sayi);

            int enBuyuk = 0;

            while (sayi > 0)
            {
                int rakam = sayi % 10; 
                if (rakam > enBuyuk)
                {
                    enBuyuk = rakam;
                }
                sayi = sayi / 10; 
            }

            Console.WriteLine("En büyük rakam: " + enBuyuk);
        }
    }
}
