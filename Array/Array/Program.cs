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

            Console.Write("ınıf Mevcıdunu Girin : ");
            int mevcut = Convert.ToInt32(Console.ReadLine());
            string[] ogrenciler = new string[mevcut];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write("{0}.Öğrenci ismini giriniz:",i);
                ogrenciler[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Ögrenci Listesi\n");
            foreach(var item in ogrenciler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
