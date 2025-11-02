using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İlk Sayıyı Giriniz: ");
            int ilksy = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            int ikincisy = int.Parse(Console.ReadLine());
            int snrilk = ikincisy;
            int snriki = ilksy;
            Console.WriteLine("İlk Sayı: " + snrilk);
            Console.WriteLine("İkinci Sayı: " + snriki);
            



        }
    }
}
