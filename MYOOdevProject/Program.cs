using System;
using System.Threading;

namespace MYOOdevProject
{
    class Program
    {
        private static double aritmetikOrt;

        /// <summary>
        /// ### 3010720153 - Mikail Aydın - Bilgisayar Programcılığı 1. Sınıf 2. Öğretim 2. Dönem Veri Yapıları ve Programlama ###
        /// </summary>
        /// 

        static void Main(string[] args)
        {

            double final = 0.0;
            double vize = 0.0;
            double ortalama = 0.0;

            Console.WriteLine("Vize Notunuzu Giriniz.");
            vize = Convert.ToDouble(Console.ReadLine());
            while (vize > 100)
            {
                Console.WriteLine("Lütfen doğru not giriniz.");
                vize = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Final Notunuzu Giriniz.");
            final = Convert.ToDouble(Console.ReadLine());
            while (final > 100)
            {
                Console.WriteLine("Lütfen doğru not giriniz.");
                final = Convert.ToDouble(Console.ReadLine());
            }

            ortalama = Ortalama(vize, final);

            if (Durumu(ortalama))
            {
                Console.WriteLine("Geçtiniz...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Kaldınız...");
            Console.ReadKey();
        }

        public static bool Durumu(double ortalama)
        {

            if (ortalama >= 50)
            {
                return true;
            }

            return false;
        }

        public static double Ortalama(double vize, double final)
        {
            aritmetikOrt = (vize + final) / 2;
            return aritmetikOrt;
        }
    }
}

