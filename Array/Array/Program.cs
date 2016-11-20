using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arrayornek

            //int[] dizi = new int[3];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = i;
            //}

            //for (int i = 0; i < dizi.Length; i++)
            //{

            //    Console.WriteLine(dizi[i]);

            //}
            //Console.ReadKey();


            #endregion

            #region arrayornek

            //Console.Write("Sınıf Mevcıdunu Girin : ");
            //int mevcut = Convert.ToInt32(Console.ReadLine());
            //string[] ogrenciler = new string[mevcut];

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.Write("{0}.Öğrenci ismini giriniz:",i);
            //    ogrenciler[i] = Console.ReadLine();
            //}
            //Console.Clear();
            //Console.WriteLine("Ögrenci Listesi\n");
            //foreach(var item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            #endregion

            #region Sayıyazdir
            //Random rnd = new Random();
            //int eksi = 0, arti = 0, sifir = 0;
            //int[] numbers = new int[10];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = rnd.Next(-1000, 1000);
            //}
            //foreach (var sayi in numbers)
            //{

            //    Console.WriteLine(sayi);

            //    if (sayi > 0)
            //    {
            //        arti++;
            //    }
            //    else if (sayi < 0)
            //    {
            //        eksi++;
            //    }
            //    else
            //    {
            //        sifir++;
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("eksi " + eksi);
            //Console.WriteLine("artı " + arti);
            //Console.WriteLine("sıfır " + sifir);
            //Console.ReadKey();

            #endregion

            #region OrnekGunler

            string[] gunler = new string[7] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            bool devam = true;
            while (devam)
            {
                Console.WriteLine("Kaçıncı Gün :");
                byte gun = Convert.ToByte(Console.ReadLine());
                if (gun <= 7 && gun >= 1)
                {
                    Console.WriteLine(gunler[gun - 1]);
                }
                else
                {
                    Console.WriteLine("Haftada 7 gün vardır.");
                }

                Console.WriteLine("Devam Etmek istiyorsan \"e\" tusuna bas");
                char c = Convert.ToChar(Console.ReadLine());
                if (c == 'e')
                {
                    devam = true;
                    Console.Clear();

                }
                else
                {
                    devam = false;
                }
            }

            #endregion


        }
    }
}
