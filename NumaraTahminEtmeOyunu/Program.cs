using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumaraTahminEtmeOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tahmindogru=false;
            Random rastgele = new Random();

            int rastgelesayı= rastgele.Next(1,11);

            Console.WriteLine("Numara tahmin etme oyununua hoşgeldiniz!");
            Console.WriteLine("1 ile 10 arasında bir sayı oluşturulacak");
            Console.WriteLine("Numarayı doğru tahmin edebilirseniz kazanırsınız");

            Console.WriteLine(rastgelesayı);

            while (!tahmindogru)
            {
                Console.WriteLine("Lütfen tahmininizi giriniz.");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > rastgelesayı)
                {
                    Console.WriteLine("Tahmininiz çok yüksek");
                }
                else if (tahmin < rastgelesayı)
                {
                    Console.WriteLine("Tahmininiz çok düşük");
                }
                else
                {
                    Console.WriteLine("Doğru!");
                    tahmindogru = true;
                }
            }
                Console.WriteLine("Tebrikler, Oyunu kazandınız!");

            Console.ReadKey();
        }
    }
}
