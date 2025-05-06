using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen aşağidaki bilgileri giriniz: ");
            Console.WriteLine("T.C Kimlik Numaranizi Giriniz: ");
            int TC_Kimlik_Numarasi= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adinizi Giriniz: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Soyadinizi Giriniz: ");
            string Soyad = Console.ReadLine();

            Console.WriteLine("Telefon Numaranizi Giriniz: ");
            int Telefon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yaşinizi Giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İlk Aldiğiniz ürün fiyatini giriniz: ");
            int ürün = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci aldiğiniz ürünün fiyatini giriniz: ");
            int ürün2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****Girmiş Olduğunuz bilgiler *****");
            Console.WriteLine("Adiniz: " + ad);
            Console.WriteLine("Soyadiniz: " + Soyad);
            Console.WriteLine("Telefon: " + Telefon);
            Console.WriteLine("Yaşiniz: " + yas);
            Console.WriteLine("İlk aldiğiniz ürün fiyati: " + ürün);
            Console.WriteLine("İkinci aldiğiniz ürün fiyati: " +ürün2);



        }
    }
}